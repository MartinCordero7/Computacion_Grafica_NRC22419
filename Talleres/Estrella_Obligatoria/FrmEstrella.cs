using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerEstrella
{
    public partial class FrmEstrella : Form
    {
        float radio = 100;
        float escala = 1f;
        PointF centro;
        float anguloRotacion = 0f; // En grados

        public FrmEstrella()
        {
            InitializeComponent();
            this.Load += FrmEstrella_Load;

            btnCalcular.Click += btnCalcular_Click;
            btnBorrar.Click += btnBorrar_Click;
            btnReset.Click += btnReset_Click;
            btnArriba.Click += btnArriba_Click;
            btnAbajo.Click += btnAbajo_Click;
            btnIzquierda.Click += btnIzquierda_Click;
            btnDerecha.Click += btnDerecha_Click;
            btnRotarIz.Click += btnRotarIz_Click;
            btnRotarDer.Click += btnRotarDer_Click;
            trBar.Scroll += trBar_Scroll;
        }

        private void FrmEstrella_Load(object sender, EventArgs e)
        {
            centro = new PointF(picCanvas.Width / 2, picCanvas.Height / 2);
            trBar.Minimum = 1;
            trBar.Maximum = 20;
            trBar.Value = 10;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtRadio.Text, out radio))
            {
                DibujarEstrella();
            }
            else
            {
                MessageBox.Show("Por favor ingrese un valor numérico válido para el radio.");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            picCanvas.Image = null;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            radio = 100;
            escala = 1f;
            anguloRotacion = 0f;
            centro = new PointF(picCanvas.Width / 2, picCanvas.Height / 2);
            trBar.Value = 10;
            txtRadio.Text = radio.ToString();
            DibujarEstrella();
        }

        private void btnArriba_Click(object sender, EventArgs e)
        {
            centro.Y -= 10;
            DibujarEstrella();
        }

        private void btnAbajo_Click(object sender, EventArgs e)
        {
            centro.Y += 10;
            DibujarEstrella();
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            centro.X -= 10;
            DibujarEstrella();
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            centro.X += 10;
            DibujarEstrella();
        }

        private void btnRotarIz_Click(object sender, EventArgs e)
        {
            anguloRotacion -= 10f;
            DibujarEstrella();
        }

        private void btnRotarDer_Click(object sender, EventArgs e)
        {
            anguloRotacion += 10f;
            DibujarEstrella();
        }

        private void trBar_Scroll(object sender, EventArgs e)
        {
            escala = trBar.Value / 10f;
            DibujarEstrella();
        }

        private void DibujarEstrella()
        {
            Bitmap bmp = new Bitmap(picCanvas.Width, picCanvas.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.Clear(Color.White);
                using (Pen pen = new Pen(Color.Black, 2))
                {
                    float radioSeguro = Math.Max(radio * escala, 50);
                    List<PointF> puntos = GenerarEstrella(radioSeguro, centro, anguloRotacion);

                    int count = puntos.Count;

                    for (int i = 0; i < count; i++)
                    {
                        for (int j = i + 1; j < count; j++)
                        {
                            int distancia = Math.Abs(i - j);

                            
                            if (distancia <= 2 || distancia >= count - 2)
                                continue;

                            
                            if (i % 2 == 1 && j % 2 == 1)
                                continue;

                            
                            if ((i % 2 == 1 && j % 2 == 1) &&
                                (Math.Abs(i - j) == 2 || Math.Abs(i - j) == 8)) 
                                continue;

                            g.DrawLine(pen, puntos[i], puntos[j]);
                        }
                    }
                }
            }
            picCanvas.Image = bmp;
        }




        private List<PointF> GenerarEstrella(float r, PointF centro, float rotacionGrados)
        {
            List<PointF> puntos = new List<PointF>();
            int puntas = 5;
            double anguloBase = Math.PI / puntas;
            double rotacionRad = rotacionGrados * Math.PI / 180.0;

            for (int i = 0; i < 2 * puntas; i++)
            {
                float rad = (i % 2 == 0) ? r : r / 2f;
                double angulo = i * anguloBase - Math.PI / 2 + rotacionRad;
                float x = (float)(centro.X + rad * Math.Cos(angulo));
                float y = (float)(centro.Y + rad * Math.Sin(angulo));
                puntos.Add(new PointF(x, y));
            }

            return puntos;
        }
    }
}
