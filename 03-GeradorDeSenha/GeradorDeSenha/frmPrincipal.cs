using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorDeSenha
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Preenche o comprimento da senha
            txbComprimento.Text = "8";

            // Ativa os checkbox
            chkMaiusculas.Checked = true;
            chkMinusculas.Checked = true;
            chkNumeros.Checked = true;
            chkSimbolos.Checked = true;
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            if (chkMaiusculas.Checked == false &&
                chkMinusculas.Checked == false &&
                chkNumeros.Checked == false && 
                chkSimbolos.Checked == false || 
                txbComprimento.Text == "")
            {
                MessageBox.Show("ATENÇÃO!!! \nSelecione uma opção para gerar a senha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (Convert.ToInt32(txbComprimento.Text) > 20 ||
                    Convert.ToInt32(txbComprimento.Text) < 8)
                {
                    MessageBox.Show("ATENÇÃO!!! \nA senha deve ter entre 8 e 20 caracteres", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    // Posiciona o cursor na caixa de texto
                    txbComprimento.Focus();
                }
                else
                {
                    int comprimento = Convert.ToInt32(txbComprimento.Text);
                    string caracteres = "";

                    if (chkMaiusculas.Checked)
                        caracteres += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    if (chkMinusculas.Checked)
                        caracteres += "abcdefghijklmnopqrstuvwxyz";
                    if (chkNumeros.Checked)
                        caracteres += "1234567890";
                    if (chkSimbolos.Checked)
                        caracteres += "!@#$%&*(){[]}/";

                    // StringBuilder modifica uma cadeia de caracteres sem criar um novo objeto
                    StringBuilder senha = new StringBuilder();
                    Random random = new Random();

                    for (int i = 0; i < comprimento; i++)
                    {
                        // Será sorteado um caracter da cadeia de "caracteres"
                        int index = random.Next(caracteres.Length);
                        // A variável "senha" receberá cada caracter sorteado
                        senha.Append(caracteres[index]);
                    }

                    // Mostra a senha no textbox
                    txbSenha.Text = senha.ToString();
                    
                }
                
            }
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbSenha.Text))
            {
                Clipboard.SetText(txbSenha.Text);
                lblAviso.Visible = true;
                timer1.Enabled = true;
                timer1.Tick += fimTimer;
                //MessageBox.Show("Senha copiada para a Área de transferência", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void fimTimer(object sender, EventArgs e)
        {
            lblAviso.Visible = false;
            timer1.Stop();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Preenche o comprimento da senha
            txbComprimento.Text = "8";

            // Ativa os checkbox
            chkMaiusculas.Checked = true;
            chkMinusculas.Checked = true;
            chkNumeros.Checked = true;
            chkSimbolos.Checked = true;

            // Limpar a caixa de senha
            txbSenha.Clear();
        }
    }
}
