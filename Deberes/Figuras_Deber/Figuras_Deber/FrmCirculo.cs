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
    public partial class FrmCirculo : Form
    {
        public FrmCirculo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtRadio.Text, out double radio))
            {
                if (radio > 0)
                {
                    double area = Math.PI * Math.Pow(radio, 2);  // Área = π * r²
                    double perimetro = 2 * Math.PI * radio;      // Perímetro = 2 * π * r

                    txtArea.Text = area.ToString("F2");
                    txtPerimetro.Text = perimetro.ToString("F2");
                }
                else
                {
                    MessageBox.Show("El radio debe ser mayor a cero.", "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un valor numérico válido para el radio.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtRadio.Text = "";
            txtArea.Text = "";
            txtPerimetro.Text = "";
            txtRadio.Focus();
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            txtRadio.Text = "";
            txtArea.Text = "";
            txtPerimetro.Text = "";
            txtRadio.Focus();
        }

        private void ValidarDecimal(KeyPressEventArgs e, TextBox caja)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            if (e.KeyChar == '.' && caja.Text.Contains("."))
                e.Handled = true;
        }

        private void txtRadio_KeyPress(object sender, KeyPressEventArgs e) => ValidarDecimal(e, txtRadio);
    }
}
