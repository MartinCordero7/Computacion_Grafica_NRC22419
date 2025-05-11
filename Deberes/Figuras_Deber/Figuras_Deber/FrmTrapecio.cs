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
    public partial class FrmTrapecio : Form
    {
        public FrmTrapecio()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtBMayor.Text, out double bMayor) &&
                double.TryParse(txtBMenor.Text, out double bMenor) &&
                double.TryParse(txtAltura.Text, out double altura) &&
                double.TryParse(txtLado1.Text, out double lado1) &&
                double.TryParse(txtLado2.Text, out double lado2))
            {
                if (bMayor > 0 && bMenor > 0 && altura > 0 && lado1 > 0 && lado2 > 0)
                {
                    double area = ((bMayor + bMenor) * altura) / 2;
                    double perimetro = bMayor + bMenor + lado1 + lado2;

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
                MessageBox.Show("Ingrese valores numéricos válidos en todos los campos.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBMayor.Text = "";
            txtBMenor.Text = "";
            txtAltura.Text = "";
            txtLado1.Text = "";
            txtLado2.Text = "";
            txtArea.Text = "";
            txtPerimetro.Text = "";
            txtBMayor.Focus();
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            txtBMayor.Text = "";
            txtBMenor.Text = "";
            txtAltura.Text = "";
            txtLado1.Text = "";
            txtLado2.Text = "";
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
        private void txtLado1_KeyPress(object sender, KeyPressEventArgs e) => ValidarDecimal(e, txtLado1);
        private void txtLado2_KeyPress(object sender, KeyPressEventArgs e) => ValidarDecimal(e, txtLado2);
    }
}
