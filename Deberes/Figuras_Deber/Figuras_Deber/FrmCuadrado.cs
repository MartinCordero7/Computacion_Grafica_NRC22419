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
    public partial class FrmCuadrado : Form
    {
        public FrmCuadrado()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Validar que sea un número válido
            if (double.TryParse(txtLado.Text, out double lado))
            {
                // Validar que sea mayor a cero
                if (lado > 0)
                {
                    double area = lado * lado;
                    double perimetro = 4 * lado;

                    txtArea.Text = area.ToString();
                    txtPerimetro.Text = perimetro.ToString();
                }
                else
                {
                    MessageBox.Show("El valor del lado debe ser mayor a cero.", "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtLado.Focus();
                }
            }
            else
            {
                MessageBox.Show("Ingrese un valor numérico válido para el lado.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLado.Focus();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtLado.Text = "";
            txtArea.Text = "";
            txtPerimetro.Text = "";
            txtLado.Focus();
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            txtLado.Text = "";
            txtArea.Text = "";
            txtPerimetro.Text = "";
            txtLado.Focus();
        }

        private void txtLado_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permitir números, punto y tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // No se permite
            }

            // Solo permitir un punto decimal
            if (e.KeyChar == '.' && txtLado.Text.Contains("."))
            {
                e.Handled = true;
            }
        }
    }
}