using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace Figuras_Deber
{
    public partial class FrmRombo : Form
    {
        public FrmRombo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtDMayor.Text, out double dMayor) &&
                double.TryParse(txtDMenor.Text, out double dMenor) &&
                double.TryParse(txtLado.Text, out double lado))
            {
                if (dMayor > 0 && dMenor > 0 && lado > 0)
                {
                    double area = (dMayor * dMenor) / 2;
                    double perimetro = 4 * lado;

                    txtArea.Text = area.ToString();
                    txtPerimetro.Text = perimetro.ToString();
                }
                else
                {
                    MessageBox.Show("Todos los valores deben ser mayores a cero.", "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Ingrese valores numéricos válidos.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDMayor.Text = "";
            txtDMenor.Text = "";
            txtLado.Text = "";
            txtArea.Text = "";
            txtPerimetro.Text = "";
            txtDMayor.Focus();
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            txtDMayor.Text = "";
            txtDMenor.Text = "";
            txtLado.Text = "";
            txtArea.Text = "";
            txtPerimetro.Text = "";
            txtDMayor.Focus();
        }

        private void ValidarDecimal(KeyPressEventArgs e, TextBox caja)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            if (e.KeyChar == '.' && caja.Text.Contains("."))
                e.Handled = true;
        }

        private void txtDMayor_KeyPress(object sender, KeyPressEventArgs e) => ValidarDecimal(e, txtDMayor);
        private void txtDMenor_KeyPress(object sender, KeyPressEventArgs e) => ValidarDecimal(e, txtDMenor);
        private void txtLado_KeyPress(object sender, KeyPressEventArgs e) => ValidarDecimal(e, txtLado);
    }
}
