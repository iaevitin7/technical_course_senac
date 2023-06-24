using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IMC
{
    public partial class Form1 : Form
    {
        double peso = 0;
        double altura = 0;
        double resultado = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            peso = Convert.ToDouble(txbPeso.Text);
            altura = Convert.ToDouble(txbAltura.Text);
            resultado = peso / (altura * altura);
            lblResultado.Text = "Resultado: " + resultado.ToString("N2");

            if (resultado < 16.9)
            {
                lblTexto.ForeColor = Color.Red;
                lblTexto.Text = "Muito abaixo do peso";
            }
            else if (resultado >= 17 && resultado <= 18.4)
            {
                lblTexto.ForeColor = Color.FromArgb(255, 128, 0); 
                lblTexto.Text = "Abaixo do peso";
            }
            else if (resultado >= 18.5 && resultado <= 24.9)
            {
                lblTexto.ForeColor = Color.Blue;
                lblTexto.Text = "Peso normal";
            }
            else if (resultado >= 25 && resultado <= 29.9)
            {
                lblTexto.ForeColor = Color.FromArgb(255, 128, 0); 
                lblTexto.Text = "Acima do peso";
            }
            else if (resultado >= 30 && resultado <= 34.9)
            {
                lblTexto.ForeColor = Color.Red;
                lblTexto.Text = "Obesidade 1";
            }
            else if (resultado >= 35 && resultado <= 40)
            {
                lblTexto.ForeColor = Color.Red;
                lblTexto.Text = "Obesidade 2";
            }
            else
            {
                lblTexto.ForeColor = Color.Red;
                lblTexto.Text = "Obesidade 3";
            }

            // Definindo o tamanho da tela
            this.Size = new Size(546, 820);
            // Encontrando o centro do comprimento
            int newX = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            // Encontrado o centro da largura
            int newY = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            // Reposicionando o form no centro da tela
            this.Location = new Point(newX, newY);
        }

        private void txbAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
            // Verifica se foi digitado um ponto e subtitui por vírgula
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }*/


            // Verifica se o caractere digitado não é um número, uma vírgula ou a tecla Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != 8)
            {
                // Cancela o evento KeyPress, impedindo que o caractere seja inserido no TextBox
                e.Handled = true;
            }

            // Verifica se o caractere digitado é uma vírgula
            if (e.KeyChar == ',')
            {
                // Verifica se já existe uma vírgula no TextBox
                if (txbAltura.Text.Contains(","))
                {
                    // Cancela o evento KeyPress, impedindo que a segunda vírgula seja inserida
                    e.Handled = true;
                }
            }
        }

        private void txbPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
            // Verifica se foi digitado um ponto e subtitui por vírgula
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }*/


            // Verifica se o caractere digitado não é um número, uma vírgula ou a tecla Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != 8)
            {
                // Cancela o evento KeyPress, impedindo que o caractere seja inserido no TextBox
                e.Handled = true;
            }

            // Verifica se o caractere digitado é uma vírgula
            if (e.KeyChar == ',')
            {
                // Verifica se já existe uma vírgula no TextBox
                if (txbPeso.Text.Contains(","))
                {
                    // Cancela o evento KeyPress, impedindo que a segunda vírgula seja inserida
                    e.Handled = true;
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbAltura.Clear();
            txbPeso.Clear();
            altura = 0;
            peso = 0;
            resultado = 0;

            lblResultado.Text = "Resultado: ";
            lblTexto.Text = string.Empty;

            // Definindo o tamanho da tela
            this.Size = new Size(546, 360);
            // Encontrando o centro do comprimento
            int newX = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            // Encontrado o centro da largura
            int newY = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            // Reposicionando o form no centro da tela
            this.Location = new Point(newX, newY);
            txbPeso.Focus();
        }
    }
}
