using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaForca
{
    public partial class Form1 : Form
    {
        // Variáveis
        private String[] palavras;
        private String[] dicas;
        private String palavra;
        private String tela;
        private int tentativas;
        private int pospalavra;


        public Form1()
        {
            InitializeComponent();
            IniciaVetor();
        }

        private void IniciaVetor()
        {
            palavras = new String[10];
            dicas = new String[10];

            palavras[0] = "abacaxi";
            dicas[0] = "Fruta tropical";

            palavras[1] = "wolverine";
            dicas[1] = "Super herói da Marvel";

            palavras[2] = "computador";
            dicas[2] = "Equipamento eletrônico";

            palavras[3] = "hyundai";
            dicas[3] = "Marca de automóvel";

            palavras[4] = "suriname";
            dicas[4] = "País da américa do sul";

            palavras[5] = "www.uol.com.br";
            dicas[5] = "Portal de notícias";

            palavras[6] = "martelo";
            dicas[6] = "Ferramenta";

            palavras[7] = "facebook";
            dicas[7] = "Rede social";

            palavras[8] = "whatsapp";
            dicas[8] = "Aplicativo de mensagens";

            palavras[9] = "felicidade";
            dicas[9] = "Sentimento de alegria";
        }

        private void IniciaJogo()
        {
            Random random = new Random();
            pospalavra = random.Next(0, 10);
            palavra = palavras[pospalavra];
            tela = "";
            for (int i = 0; i < palavra.Length; i++)
            {
                tela = tela + "*";
            }
            txbPalavra.Text = tela;
            lblDica.Text = dicas[pospalavra];
            tentativas = 6;
            lblTentativasRestantes.Text = tentativas.ToString();
            lblLetrasDigitadas.Text = "";
            picImagem.Image = Properties.Resources.forca_0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picCenario.Location = new Point(10, 10);
            SoundPlayer Inicio = new SoundPlayer(@"inicio.wav");
            Inicio.Play();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            picCenario.Visible = false;
            IniciaJogo();
            btnOk.Enabled = true;
            txbLetra.Enabled = true;
            txbLetra.Focus();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            bool encontrou = false;
            int posicaoLetra = 0;
            Char letra = '0';

            if (lblLetrasDigitadas.Text.Length <= 0)
            {
                lblLetrasDigitadas.Text = lblLetrasDigitadas.Text + txbLetra.Text;
            }
            else
            {
                lblLetrasDigitadas.Text = lblLetrasDigitadas.Text + ", " + txbLetra.Text;
            }

            try
            {
                letra = Convert.ToChar(txbLetra.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Digite somente letras", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
                
            }

            string txt = "";

            for (int i = 0; i < palavra.Length; i++)
            {
                if (palavra[i] == letra)
                {
                    encontrou = true;
                    SoundPlayer Acertou = new SoundPlayer(@"acertou.wav"); 
                    Acertou.Play();
                    posicaoLetra = i;
                    txt = txt + txbLetra.Text;
                }
                else
                {
                    txt = txt + tela[i];
                }
            }

            tela = txt;
            txbPalavra.Text = tela;
            txbLetra.Clear();
            txbLetra.Focus();

            if (encontrou == false)
            {
                tentativas--;
                SoundPlayer Errou = new SoundPlayer(@"ai.wav");
                Errou.Play();

                switch (tentativas)
                {
                    case 5:
                        picImagem.Image = Properties.Resources.forca_1;
                        break;

                    case 4:
                        picImagem.Image = Properties.Resources.forca_2;
                        break;

                    case 3:
                        picImagem.Image = Properties.Resources.forca_3;
                        break;

                    case 2:
                        picImagem.Image = Properties.Resources.forca_4;
                        break;

                    case 1:
                        picImagem.Image = Properties.Resources.forca_5;
                        break;
                }
            }

            lblTentativasRestantes.Text = tentativas.ToString();
            if (txbPalavra.Text.IndexOf('*') == -1)
            {
                SoundPlayer Ganhou = new SoundPlayer(@"ganhou.wav");
                Ganhou.Play();
                picImagem.Image = Properties.Resources.parabens;
                btnOk.Enabled = false;
                txbLetra.Enabled = false;
            }

            if (tentativas <= 0)
            {
                picImagem.Image = Properties.Resources.forca_6;
                btnOk.Enabled = false;
                txbLetra.Enabled = false;
                lblTentativasRestantes.Text = "Morreu";
                timer1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            picImagem.Image = Properties.Resources.gamerover;
            picImagem.SizeMode = PictureBoxSizeMode.Zoom;
            SoundPlayer Perdeu = new SoundPlayer(@"perdeu.wav");
            Perdeu.Play();
        }
    }
}
