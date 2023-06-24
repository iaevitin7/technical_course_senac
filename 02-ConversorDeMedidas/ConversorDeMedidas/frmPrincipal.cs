using System.Windows.Forms;
using System;

namespace ConversorDeMedidas
{
    public partial class frmPrincipal : Form
    {
        double celsius, fahrenheit, milimetros, centimetros, polegadas;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnGraus_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txbCelsius.Text, out celsius))
            {
                fahrenheit = (celsius * 9 / 5) + 32;
                txbFahrenheit.Text = fahrenheit.ToString();
            }
        }

        private void rdbMilimetros_CheckedChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txbCM.Text, out centimetros))
            {
                milimetros = centimetros * 10;
                txbResultado.Text = milimetros.ToString();
            }
        }

        private void rdbPolegadas_CheckedChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txbCM.Text, out centimetros))
            {
                polegadas = centimetros / 2.54;
                txbResultado.Text = polegadas.ToString();
            }
        }
    }
}