namespace GeradorDeSenha
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbComprimento = new System.Windows.Forms.TextBox();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkMinusculas = new System.Windows.Forms.CheckBox();
            this.chkMaiusculas = new System.Windows.Forms.CheckBox();
            this.chkNumeros = new System.Windows.Forms.CheckBox();
            this.chkSimbolos = new System.Windows.Forms.CheckBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblAviso = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gerador de Senhas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GeradorDeSenha.Properties.Resources.senha;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Comprimento da senha:";
            // 
            // txbComprimento
            // 
            this.txbComprimento.Location = new System.Drawing.Point(239, 92);
            this.txbComprimento.Name = "txbComprimento";
            this.txbComprimento.Size = new System.Drawing.Size(100, 20);
            this.txbComprimento.TabIndex = 3;
            // 
            // txbSenha
            // 
            this.txbSenha.Enabled = false;
            this.txbSenha.Location = new System.Drawing.Point(413, 92);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(275, 20);
            this.txbSenha.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Senha gerada:";
            // 
            // chkMinusculas
            // 
            this.chkMinusculas.AutoSize = true;
            this.chkMinusculas.Location = new System.Drawing.Point(239, 133);
            this.chkMinusculas.Name = "chkMinusculas";
            this.chkMinusculas.Size = new System.Drawing.Size(79, 17);
            this.chkMinusculas.TabIndex = 6;
            this.chkMinusculas.Text = "Minúsculas";
            this.chkMinusculas.UseVisualStyleBackColor = true;
            // 
            // chkMaiusculas
            // 
            this.chkMaiusculas.AutoSize = true;
            this.chkMaiusculas.Location = new System.Drawing.Point(239, 160);
            this.chkMaiusculas.Name = "chkMaiusculas";
            this.chkMaiusculas.Size = new System.Drawing.Size(79, 17);
            this.chkMaiusculas.TabIndex = 7;
            this.chkMaiusculas.Text = "Maiúsculas";
            this.chkMaiusculas.UseVisualStyleBackColor = true;
            // 
            // chkNumeros
            // 
            this.chkNumeros.AutoSize = true;
            this.chkNumeros.Location = new System.Drawing.Point(326, 133);
            this.chkNumeros.Name = "chkNumeros";
            this.chkNumeros.Size = new System.Drawing.Size(68, 17);
            this.chkNumeros.TabIndex = 8;
            this.chkNumeros.Text = "Números";
            this.chkNumeros.UseVisualStyleBackColor = true;
            // 
            // chkSimbolos
            // 
            this.chkSimbolos.AutoSize = true;
            this.chkSimbolos.Location = new System.Drawing.Point(326, 160);
            this.chkSimbolos.Name = "chkSimbolos";
            this.chkSimbolos.Size = new System.Drawing.Size(70, 17);
            this.chkSimbolos.TabIndex = 9;
            this.chkSimbolos.Text = "Símbolos";
            this.chkSimbolos.UseVisualStyleBackColor = true;
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(413, 140);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(75, 36);
            this.btnGerar.TabIndex = 10;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // btnCopiar
            // 
            this.btnCopiar.Location = new System.Drawing.Point(513, 141);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(75, 36);
            this.btnCopiar.TabIndex = 11;
            this.btnCopiar.Text = "Copiar";
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(613, 141);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 36);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.ForeColor = System.Drawing.Color.Red;
            this.lblAviso.Location = new System.Drawing.Point(415, 185);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(216, 13);
            this.lblAviso.TabIndex = 13;
            this.lblAviso.Text = "Senha copiada para a Área de transferência";
            this.lblAviso.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 207);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCopiar);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.chkSimbolos);
            this.Controls.Add(this.chkNumeros);
            this.Controls.Add(this.chkMaiusculas);
            this.Controls.Add(this.chkMinusculas);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbComprimento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de Senhas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbComprimento;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkMinusculas;
        private System.Windows.Forms.CheckBox chkMaiusculas;
        private System.Windows.Forms.CheckBox chkNumeros;
        private System.Windows.Forms.CheckBox chkSimbolos;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Timer timer1;
    }
}

