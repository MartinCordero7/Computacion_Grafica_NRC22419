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
    public partial class FrmTrapezoide : Form
    {
        public FrmTrapezoide()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtLado1.Text, out double lado1) &&
                double.TryParse(txtLado2.Text, out double lado2) &&
                double.TryParse(txtLado3.Text, out double lado3) &&
                double.TryParse(txtLado4.Text, out double lado4))
            {
                if (lado1 > 0 && lado2 > 0 && lado3 > 0 && lado4 > 0)
                {
                    double perimetro = lado1 + lado2 + lado3 + lado4;

                    txtPerimetro.Text = perimetro.ToString();
                    txtArea.Text = "No disponible";  // Área no se calcula con solo lados
                }
                else
                {
                    MessageBox.Show("Todos los lados deben ser mayores a cero.", "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Ingrese valores numéricos válidos en todos los campos.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtLado1.Text = "";
            txtLado2.Text = "";
            txtLado3.Text = "";
            txtLado4.Text = "";
            txtArea.Text = "";
            txtPerimetro.Text = "";
            txtLado1.Focus();
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            txtLado1.Text = "";
            txtLado2.Text = "";
            txtLado3.Text = "";
            txtLado4.Text = "";
            txtArea.Text = "";
            txtPerimetro.Text = "";
            txtLado1.Focus();
        }

        private void ValidarDecimal(KeyPressEventArgs e, TextBox caja)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            if (e.KeyChar == '.' && caja.Text.Contains("."))
                e.Handled = true;
        }

        private void txtLado1_KeyPress(object sender, KeyPressEventArgs e) => ValidarDecimal(e, txtLado1);
        private void txtLado2_KeyPress(object sender, KeyPressEventArgs e) => ValidarDecimal(e, txtLado2);
        private void txtLado3_KeyPress(object sender, KeyPressEventArgs e) => ValidarDecimal(e, txtLado3);
        private void txtLado4_KeyPress(object sender, KeyPressEventArgs e) => ValidarDecimal(e, txtLado4);
    }
}
