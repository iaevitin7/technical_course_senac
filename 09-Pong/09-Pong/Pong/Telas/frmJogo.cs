using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong.Telas
{
    public partial class frmJogo : Form
    {

        // Variáveis
        int velocidade, resultado;
        bool topo, esquerda;

        private void frmJogo_Load(object sender, EventArgs e)
        {
            Random bola = new Random();
            picBolinha.Location = new Point(0, bola.Next(this.Height));
            topo = esquerda = true;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Verifica se a bolinha passou pela raquete
            if (picBolinha.Left > picRaquete.Left)
            {
                timer1.Enabled = false;
                if (resultado == 1)
                {
                    MessageBox.Show("Perdeu!!! \nVocê fez " + resultado.ToString() + " ponto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Perdeu!!! \nVocê fez " + resultado.ToString() + " pontos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                resultado = 0;
            }

            if (picBolinha.Left + picBolinha.Width >= picRaquete.Left && 
                picBolinha.Left + picBolinha.Width <= picRaquete.Left + picRaquete.Width &&
                picBolinha.Top + picBolinha.Height >= picRaquete.Top &&
                picBolinha.Top + picBolinha.Height <= picRaquete.Top + picRaquete.Height + picBolinha.Height)
            {
                esquerda = false;
                resultado += 1;
                SoundPlayer Som = new SoundPlayer(@"pong.wav");
                Som.Play();
                this.Text = "Seus pontos: " + resultado.ToString();
            }

            if (esquerda)
                picBolinha.Left += velocidade;
            else
                picBolinha.Left -= velocidade;
            if(topo)
                picBolinha.Top += velocidade;
            else
                picBolinha.Top -= velocidade;
            if(picBolinha.Top >= this.Height - 70)
                topo = false;
            if (picBolinha.Top <= 5)
                topo = true;
            if (picBolinha.Left <= 0)
                esquerda = true;
        }

        public frmJogo(int valor, int velo)
        {
            InitializeComponent();
            if (valor == 0 )
            {
                valor = 100;
            }
            else
            {
                picRaquete.Height = valor;
            }
            velocidade = velo;
        }

        private void frmJogo_MouseMove(object sender, MouseEventArgs e)
        {
            picRaquete.Top = e.Y - (picRaquete.Height / 2 );
        }
    }
}
