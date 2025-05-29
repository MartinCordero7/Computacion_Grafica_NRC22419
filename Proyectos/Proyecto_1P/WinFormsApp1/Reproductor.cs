using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using NAudio.Wave;
using Timer = System.Windows.Forms.Timer;

namespace Proyecto1
{
    public partial class Reproductor : Form
    {
        private Timer timer1 = new Timer();
        private Random random = new Random();
        private int[] values;
        private int currentStep = 0;
        private bool isPlaying = false;
        private AudioAnalyzer audioAnalyzer;
        private string currentAudioFile = ""; 

        private enum AnimacionTipo
        {
            Barras,
            Rombos,
            Circular,
            Estrella,
            Radiantes,
            Rejilla
        }

        private AnimacionTipo animacionActual = AnimacionTipo.Barras;
        private DateTime ultimaAnimacionCambio;
        private TimeSpan intervaloCambio = TimeSpan.FromSeconds(5);

        private Dictionary<AnimacionTipo, IAnimacion> animaciones;

        public Reproductor()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            timer1.Interval = 100;
            timer1.Tick += timer1_Tick;

            values = new int[60];
            

            animaciones = new Dictionary<AnimacionTipo, IAnimacion>
            {
                { AnimacionTipo.Barras, new Barras() },
                { AnimacionTipo.Rombos, new Rombos() },
                { AnimacionTipo.Circular, new Circular() },
                { AnimacionTipo.Estrella, new Estrella() },
                { AnimacionTipo.Radiantes, new Radiantes() },
                { AnimacionTipo.Rejilla, new Rejillas() }
            };

            audioAnalyzer = new AudioAnalyzer();
            
            currentAudioFile = "musica/musica.mp3";
            audioAnalyzer.Load(currentAudioFile);

            picCanvas.Paint += picCanvas_Paint;
        }

        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            isPlaying = !isPlaying;

            if (isPlaying)
            {
                ultimaAnimacionCambio = DateTime.Now;
                timer1.Start();
                audioAnalyzer.Play();
            }
            else
            {
                timer1.Stop();
                audioAnalyzer.Pause();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            isPlaying = false;
            timer1.Stop();
            audioAnalyzer.Stop();
            progBar.Value = 0;
            currentStep = 0;
            picCanvas.Invalidate();
        }

        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            animacionActual = (AnimacionTipo)(((int)animacionActual + 1) % Enum.GetValues(typeof(AnimacionTipo)).Length);
            ultimaAnimacionCambio = DateTime.Now;
            progBar.Value = 0;
            picCanvas.Invalidate();
        }

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            int total = Enum.GetValues(typeof(AnimacionTipo)).Length;
            animacionActual = (AnimacionTipo)(((int)animacionActual - 1 + total) % total);
            ultimaAnimacionCambio = DateTime.Now;
            progBar.Value = 0;
            picCanvas.Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var amps = audioAnalyzer.GetAmplitudes(60);
            float maxAmp = amps.Max();
            if (maxAmp == 0f) maxAmp = 1f;

            values = amps.Select((v, i) =>
            {
                int val = (int)((v / maxAmp) * (picCanvas.Height - 20) * 20) + 10;
                val = Math.Max(10, val);
                val = Math.Min(val, picCanvas.Height - 10);
                return val;
            }).ToArray();

            currentStep++;

            TimeSpan elapsed = DateTime.Now - ultimaAnimacionCambio;
            if (elapsed >= intervaloCambio)
            {
                animacionActual = (AnimacionTipo)(((int)animacionActual + 1) % Enum.GetValues(typeof(AnimacionTipo)).Length);
                ultimaAnimacionCambio = DateTime.Now;
                progBar.Value = 0;
            }
            else
            {
                int progreso = (int)(100.0 * elapsed.TotalMilliseconds / intervaloCambio.TotalMilliseconds);
                progBar.Value = Math.Min(100, Math.Max(0, progreso));
            }

            picCanvas.Invalidate();
        }


        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.Black);

            animaciones[animacionActual].Dibujar(g, values, picCanvas, currentStep);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            audioAnalyzer?.Dispose();
            base.OnFormClosing(e);
        }
    }
}
