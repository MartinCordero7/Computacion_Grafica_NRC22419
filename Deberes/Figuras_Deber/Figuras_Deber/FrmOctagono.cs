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
    public partial class FrmOctagono : Form
    {
        public FrmOctagono()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            if (double.TryParse(txtLado.Text, out double lado) && double.TryParse(txtApotema.Text, out double apotema))
            {
                if (lado > 0 && apotema > 0)
                {
                    int numeroLados = 8;
                    double perimetro = numeroLados * lado;
                    double area = (perimetro * apotema) / 2;

                    txtPerimetro.Text = perimetro.ToString();
                    txtArea.Text = area.ToString();
                }
                else
                {
                    MessageBox.Show("El lado y la apotema deben ser mayores a cero.", "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Ingrese valores numéricos válidos para el lado y la apotema.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtLado.Text = "";
            txtApotema.Text = "";
            txtArea.Text = "";
            txtPerimetro.Text = "";
            txtLado.Focus();
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            txtLado.Text = "";
            txtApotema.Text = "";
            txtArea.Text = "";
            txtPerimetro.Text = "";
            txtLado.Focus();
        }

        private void txtLado_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            if (e.KeyChar == '.' && txtLado.Text.Contains("."))
                e.Handled = true;
        }

        private void txtApotema_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            if (e.KeyChar == '.' && txtApotema.Text.Contains("."))
                e.Handled = true;
        }
    }
}
