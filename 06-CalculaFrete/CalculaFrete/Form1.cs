using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculaFrete
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void BuscaCep()
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/" + mskCep.Text + "/json/");
                request.AllowAutoRedirect = false;
                HttpWebResponse ChecaServidor = (HttpWebResponse)request.GetResponse();

                if (ChecaServidor.StatusCode != HttpStatusCode.OK)
                {
                    MessageBox.Show("Servidor indisponível", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return; // Sai da rotina
                }

                using (Stream webStream = ChecaServidor.GetResponseStream())
                {
                    if (webStream != null)
                    {
                        using (StreamReader responseReader = new StreamReader(webStream))
                        {
                            string response = responseReader.ReadToEnd();
                            response = Regex.Replace(response, "[{},]", string.Empty);
                            response = response.Replace("\"", "");

                            String[] substrings = response.Split('\n');

                            int cont = 0;
                            foreach (var substring in substrings)
                            {
                                if (cont == 1)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    if (valor[0] == "  erro")
                                    {
                                        MessageBox.Show("CEP não encontrado");
                                        mskCep.Focus();
                                        return;
                                    }
                                }

                                //Logradouro
                                if (cont == 2)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    txbLogradouro.Text = valor[1];
                                }

                                //Complemento
                                if (cont == 3)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    txbComplemento.Text = valor[1];
                                }

                                //Bairro
                                if (cont == 4)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    txbBairro.Text = valor[1];
                                }

                                //Localidade (Cidade)
                                if (cont == 5)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    txbCidade.Text = valor[1];
                                }

                                //Estado (UF)
                                if (cont == 6)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    txbEstado.Text = valor[1];
                                }

                                cont++;
                            }
                        }
                        txbNumero.Focus();
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Atenção! Digite corretamente o CEP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mskCep.Focus();
            }
        }

        private void mskCep_Leave(object sender, EventArgs e)
        {
            BuscaCep();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (Verifica())
            {
                Calcula();
            }
        }


        public Boolean Verifica()
        {
            if (txbNome.Text == string.Empty)
            {
                MessageBox.Show("Digite o nome", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbNome.Focus();
                return false;
            }

            if (mskCep.Text == string.Empty)
            {
                MessageBox.Show("Digite o CEP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mskCep.Focus();
                return false;
            }

            if (txbNumero.Text == string.Empty)
            {
                MessageBox.Show("Digite o número", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbNumero.Focus();
                return false;
            }

            if (txbValor.Text == string.Empty)
            {
                MessageBox.Show("Digite o valor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbValor.Focus();
                return false;
            }
            return true;
        }


        public void Calcula()
        {
            //Declarando as variáveis
            decimal valor = Convert.ToDecimal(txbValor.Text);
            string estado = txbEstado.Text.Trim().ToUpper();
            decimal frete = 0, total = 0;

            // Cálculo do frete
            if (valor > 1000)
            {
                frete = 0;
            }
            else
            {
                switch (estado)
                {
                    case "SP":
                        frete = 5;
                        break;

                    case "RJ":
                        frete = 10;
                        break;

                    case "AM":
                        frete = 20;
                        break;

                    default:
                        frete = 15; 
                        break;
                }
            }

            // A variável total recebe o valor digitado mais o frete
            total = valor + frete;

            // Mostrar os valores nos labels
            lblValor.Text = valor.ToString("C");
            lblFrete.Text = frete.ToString("C");
            lblTotal.Text = total.ToString("C");

            // Mostrar a imagem
            pictureBox1.Image = Properties.Resources.correio;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpa();
        }


        public void Limpa()
        {
            // Limpando os textBox
            txbNome.Clear();
            mskCep.Clear();
            txbNumero.Clear();
            txbLogradouro.Clear();
            txbBairro.Clear();
            txbCidade.Clear();
            txbComplemento.Clear();
            txbEstado.Clear();
            txbValor.Clear();

            // Limpando os labels
            lblValor.Text = string.Empty;
            lblFrete.Text = string.Empty;
            lblTotal.Text = string.Empty;

            // Limpar o pictureBox
            pictureBox1.Image = null;

            // Posicionar o cursor
            txbNome.Focus();
        }
    }
}
