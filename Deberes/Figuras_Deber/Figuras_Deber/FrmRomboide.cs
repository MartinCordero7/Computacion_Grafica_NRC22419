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
    public partial class FrmRomboide : Form
    {
        public FrmRomboide()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtBase.Text, out double baseR) &&
                double.TryParse(txtAltura.Text, out double altura) &&
                double.TryParse(txtOblicuo.Text, out double oblicuo))
            {
                if (baseR > 0 && altura > 0 && oblicuo > 0)
                {
                    double area = baseR * altura;
                    double perimetro = 2 * (baseR + oblicuo);

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
                MessageBox.Show("Ingrese valores numéricos válidos para base, altura y lado oblicuo.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBase.Text = "";
            txtAltura.Text = "";
            txtOblicuo.Text = "";
            txtArea.Text = "";
            txtPerimetro.Text = "";
            txtBase.Focus();
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            txtBase.Text = "";
            txtAltura.Text = "";
            txtOblicuo.Text = "";
            txtArea.Text = "";
            txtPerimetro.Text = "";
            txtBase.Focus();
        }

        private void txtBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            if (e.KeyChar == '.' && txtBase.Text.Contains("."))
                e.Handled = true;
        }

        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            if (e.KeyChar == '.' && txtAltura.Text.Contains("."))
                e.Handled = true;
        }

        private void txtOblicuo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            if (e.KeyChar == '.' && txtOblicuo.Text.Contains("."))
                e.Handled = true;
        }
    }
}