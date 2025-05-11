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
    public partial class FrmElipse : Form
{
    public FrmElipse()
    {
        InitializeComponent();
    }

    private void btnCalcular_Click(object sender, EventArgs e)
    {
        if (double.TryParse(txtEMayor.Text, out double eMayor) &&
            double.TryParse(txtEMenor.Text, out double eMenor))
        {
            if (eMayor > 0 && eMenor > 0)
            {
               
                double area = Math.PI * (eMayor / 2) * (eMenor / 2);

                
                double perimetro = Math.PI * (3 * (eMayor / 2 + eMenor / 2) -
                    Math.Sqrt((3 * eMayor + eMenor) * (eMayor + 3 * eMenor)));

                txtArea.Text = area.ToString("F2");
                txtPerimetro.Text = perimetro.ToString("F2");
            }
            else
            {
                MessageBox.Show("Ambos ejes deben ser mayores a cero.", "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        else
        {
            MessageBox.Show("Ingrese valores numéricos válidos para los ejes mayor y menor.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
        txtEMayor.Text = "";
        txtEMenor.Text = "";
        txtArea.Text = "";
        txtPerimetro.Text = "";
        txtEMayor.Focus();
    }

    private void btnResetear_Click(object sender, EventArgs e)
    {
        txtEMayor.Text = "";
        txtEMenor.Text = "";
        txtArea.Text = "";
        txtPerimetro.Text = "";
        txtEMayor.Focus();
    }

    private void ValidarDecimal(KeyPressEventArgs e, TextBox caja)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            e.Handled = true;

        if (e.KeyChar == '.' && caja.Text.Contains("."))
            e.Handled = true;
    }

    private void txtEMayor_KeyPress(object sender, KeyPressEventArgs e) => ValidarDecimal(e, txtEMayor);
    private void txtEMenor_KeyPress(object sender, KeyPressEventArgs e) => ValidarDecimal(e, txtEMenor);
}
}
