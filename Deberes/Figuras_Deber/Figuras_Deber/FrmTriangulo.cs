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
    public partial class FrmTriangulo : Form
    {
        public FrmTriangulo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtBase.Text, out double baseT) && double.TryParse(txtAltura.Text, out double altura))
            {
                if (baseT > 0 && altura > 0)
                {
                    double area = (baseT * altura) / 2;
                    double perimetro = 3 * baseT; 

                    txtArea.Text = area.ToString();
                    txtPerimetro.Text = perimetro.ToString();
                }
                else
                {
                    MessageBox.Show("Base y altura deben ser mayores a cero.", "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Ingrese valores numéricos válidos para base y altura.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBase.Text = "";
            txtAltura.Text = "";
            txtArea.Text = "";
            txtPerimetro.Text = "";
            txtBase.Focus();
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            txtBase.Text = "";
            txtAltura.Text = "";
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
    }
}
