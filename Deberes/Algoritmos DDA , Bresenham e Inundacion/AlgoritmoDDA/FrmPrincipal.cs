using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bresenham;
using AlgoritmoDDA;
using AlgoritmoCircunferencia;
using Algoritmo_DDA;

namespace Algoritmos
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void AbrirUnicaVentana<T>() where T : Form, new()
        {
            foreach (var form in this.MdiChildren)
            {
                form.Close();
            }

            // Crea y muestra una nueva instancia de la ventana
            var nuevaVentana = new T { MdiParent = this };
            nuevaVentana.Show();
        }

        private void SALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fIGURASToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void algoritmoDDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirUnicaVentana<FrmDDA>();
        }

        private void algoritmoBresenhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirUnicaVentana<FrmBresenham>();
        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void algoritmoPuntoMedioCirculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirUnicaVentana<FrmCircunferencia>();
        }

        private void algorimtmoRellenoPorInundaciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirUnicaVentana<FrmFloodFill>();
        }
    }
}
