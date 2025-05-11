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
    public partial class FrmTrapecioI : Form
    {
        public FrmTrapecioI()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtBMayor.Text, out double bMayor) &&
                double.TryParse(txtBMenor.Text, out double bMenor) &&
                double.TryParse(txtAltura.Text, out double altura) &&
                double.TryParse(txtLado.Text, out double lado))
            {
                if (bMayor > 0 && bMenor > 0 && altura > 0 && lado > 0)
                {
                    double area = ((bMayor + bMenor) * altura) / 2;
                    double perimetro = bMayor + bMenor + 2 * lado;

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
            txtBMayor.Text = "";
            txtBMenor.Text = "";
            txtAltura.Text = "";
            txtLado.Text = "";
            txtArea.Text = "";
            txtPerimetro.Text = "";
            txtBMayor.Focus();
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            txtBMayor.Text = "";
            txtBMenor.Text = "";
            txtAltura.Text = "";
            txtLado.Text = "";
            txtArea.Text = "";
            txtPerimetro.Text = "";
            txtBMayor.Focus();
        }

        private void ValidarDecimal(KeyPressEventArgs e, TextBox caja)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            if (e.KeyChar == '.' && caja.Text.Contains("."))
                e.Handled = true;
        }

        private void txtBMayor_KeyPress(object sender, KeyPressEventArgs e) => ValidarDecimal(e, txtBMayor);
        private void txtBMenor_KeyPress(object sender, KeyPressEventArgs e) => ValidarDecimal(e, txtBMenor);
        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e) => ValidarDecimal(e, txtAltura);
        private void txtLado_KeyPress(object sender, KeyPressEventArgs e) => ValidarDecimal(e, txtLado);
    }
}