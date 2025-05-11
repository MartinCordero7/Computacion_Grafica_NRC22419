using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras_Deber
{
    public partial class FrmPrinc : Form
    {
        public FrmPrinc()
        {
            InitializeComponent();
        }

        private void abrirFormulario(Form formulario)
        {
            // Verifica si la ventana ya está abierta
            Form formAbierto = Application.OpenForms.Cast<Form>().FirstOrDefault(f => f.GetType() == formulario.GetType());

            if (formAbierto == null)
            {
                // Si no está abierta, la muestra
                formulario.Show();
            }
            else
            {
                // Si ya está abierta, la trae al frente
                formAbierto.Activate();
            }
        }

        private void cuadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCuadrado cuadrado = new FrmCuadrado();
            abrirFormulario(cuadrado);
        }

        private void pentagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPentagono pentagono = new FrmPentagono();
            abrirFormulario(pentagono);
        }

        private void hexagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHexagono hexagono = new FrmHexagono();
            abrirFormulario(hexagono);
        }

        private void heptagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHeptagono heptagono = new FrmHeptagono();
            abrirFormulario(heptagono);
        }

        private void octagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOctagono octagono = new FrmOctagono();
            abrirFormulario(octagono);
        }

        private void eneagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEneagono eneagono = new FrmEneagono();
            abrirFormulario(eneagono);
        }

        private void decagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDecagono decagono = new FrmDecagono();
            abrirFormulario(decagono);
        }

        private void rectanguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRectangulo rectangulo = new FrmRectangulo();
            abrirFormulario(rectangulo);
        }

        private void romboideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRomboide romboide = new FrmRomboide();
            abrirFormulario(romboide);
        }

        private void trapecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTrapecio trapecio = new FrmTrapecio();
            abrirFormulario(trapecio);
        }

        private void trapezoideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTrapecioI trapecioi = new FrmTrapecioI();
            abrirFormulario(trapecioi);
        }

        private void trianguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTrapezoide trapezoide = new FrmTrapezoide();
            abrirFormulario(trapezoide);
        }

        private void trianguloToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmTriangulo triangulo = new FrmTriangulo();
            abrirFormulario(triangulo);
        }

        private void romboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRombo rombo = new FrmRombo();
            abrirFormulario(rombo);
        }

        private void deltoideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDeltoide deltoide = new FrmDeltoide();
            abrirFormulario(deltoide);
        }

        private void circuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCirculo circulo = new FrmCirculo();
            abrirFormulario(circulo);
        }

        private void elipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmElipse elipse = new FrmElipse();
            abrirFormulario(elipse);
        }

        private void ovaloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOvalo ovalo = new FrmOvalo();
            abrirFormulario(ovalo);
        }
    }
}
