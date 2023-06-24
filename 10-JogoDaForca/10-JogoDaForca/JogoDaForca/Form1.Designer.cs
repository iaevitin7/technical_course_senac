namespace JogoDaForca
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnJogo = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblLetrasDigitadas = new System.Windows.Forms.Label();
            this.grpDica = new System.Windows.Forms.GroupBox();
            this.lblDica = new System.Windows.Forms.Label();
            this.grpJogo = new System.Windows.Forms.GroupBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.txbLetra = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTentativasRestantes = new System.Windows.Forms.Label();
            this.txbPalavra = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.picCenario = new System.Windows.Forms.PictureBox();
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnJogo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpDica.SuspendLayout();
            this.grpJogo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCenario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // pnJogo
            // 
            this.pnJogo.Controls.Add(this.picImagem);
            this.pnJogo.Controls.Add(this.groupBox2);
            this.pnJogo.Controls.Add(this.grpDica);
            this.pnJogo.Controls.Add(this.grpJogo);
            this.pnJogo.Controls.Add(this.groupBox1);
            this.pnJogo.Controls.Add(this.txbPalavra);
            this.pnJogo.Location = new System.Drawing.Point(11, 12);
            this.pnJogo.Name = "pnJogo";
            this.pnJogo.Size = new System.Drawing.Size(500, 500);
            this.pnJogo.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblLetrasDigitadas);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(485, 65);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Letras digitadas";
            // 
            // lblLetrasDigitadas
            // 
            this.lblLetrasDigitadas.ForeColor = System.Drawing.Color.Red;
            this.lblLetrasDigitadas.Location = new System.Drawing.Point(6, 28);
            this.lblLetrasDigitadas.Name = "lblLetrasDigitadas";
            this.lblLetrasDigitadas.Size = new System.Drawing.Size(450, 32);
            this.lblLetrasDigitadas.TabIndex = 0;
            this.lblLetrasDigitadas.Text = "5";
            this.lblLetrasDigitadas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpDica
            // 
            this.grpDica.Controls.Add(this.lblDica);
            this.grpDica.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDica.Location = new System.Drawing.Point(9, 42);
            this.grpDica.Name = "grpDica";
            this.grpDica.Size = new System.Drawing.Size(485, 65);
            this.grpDica.TabIndex = 5;
            this.grpDica.TabStop = false;
            this.grpDica.Text = "Dica";
            // 
            // lblDica
            // 
            this.lblDica.ForeColor = System.Drawing.Color.Blue;
            this.lblDica.Location = new System.Drawing.Point(6, 29);
            this.lblDica.Name = "lblDica";
            this.lblDica.Size = new System.Drawing.Size(450, 24);
            this.lblDica.TabIndex = 0;
            this.lblDica.Text = "dica";
            // 
            // grpJogo
            // 
            this.grpJogo.Controls.Add(this.btnOk);
            this.grpJogo.Controls.Add(this.txbLetra);
            this.grpJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpJogo.Location = new System.Drawing.Point(9, 317);
            this.grpJogo.Name = "grpJogo";
            this.grpJogo.Size = new System.Drawing.Size(182, 178);
            this.grpJogo.TabIndex = 4;
            this.grpJogo.TabStop = false;
            this.grpJogo.Text = "Digite uma letra:";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(29, 113);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(124, 46);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Adivinhar";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txbLetra
            // 
            this.txbLetra.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txbLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLetra.Location = new System.Drawing.Point(29, 45);
            this.txbLetra.MaxLength = 1;
            this.txbLetra.Name = "txbLetra";
            this.txbLetra.Size = new System.Drawing.Size(124, 53);
            this.txbLetra.TabIndex = 0;
            this.txbLetra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTentativasRestantes);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 75);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chances";
            // 
            // lblTentativasRestantes
            // 
            this.lblTentativasRestantes.AutoSize = true;
            this.lblTentativasRestantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTentativasRestantes.ForeColor = System.Drawing.Color.Red;
            this.lblTentativasRestantes.Location = new System.Drawing.Point(13, 23);
            this.lblTentativasRestantes.Name = "lblTentativasRestantes";
            this.lblTentativasRestantes.Size = new System.Drawing.Size(42, 46);
            this.lblTentativasRestantes.TabIndex = 0;
            this.lblTentativasRestantes.Text = "6";
            // 
            // txbPalavra
            // 
            this.txbPalavra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbPalavra.Enabled = false;
            this.txbPalavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPalavra.Location = new System.Drawing.Point(9, 4);
            this.txbPalavra.Name = "txbPalavra";
            this.txbPalavra.Size = new System.Drawing.Size(485, 38);
            this.txbPalavra.TabIndex = 1;
            this.txbPalavra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(11, 518);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(500, 42);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Iniciar";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // picCenario
            // 
            this.picCenario.Image = ((System.Drawing.Image)(resources.GetObject("picCenario.Image")));
            this.picCenario.Location = new System.Drawing.Point(571, 26);
            this.picCenario.Name = "picCenario";
            this.picCenario.Size = new System.Drawing.Size(500, 500);
            this.picCenario.TabIndex = 8;
            this.picCenario.TabStop = false;
            // 
            // picImagem
            // 
            this.picImagem.Location = new System.Drawing.Point(194, 195);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(300, 300);
            this.picImagem.TabIndex = 7;
            this.picImagem.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 571);
            this.Controls.Add(this.picCenario);
            this.Controls.Add(this.pnJogo);
            this.Controls.Add(this.btnStart);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Forca";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnJogo.ResumeLayout(false);
            this.pnJogo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.grpDica.ResumeLayout(false);
            this.grpJogo.ResumeLayout(false);
            this.grpJogo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCenario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCenario;
        private System.Windows.Forms.Panel pnJogo;
        private System.Windows.Forms.PictureBox picImagem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblLetrasDigitadas;
        private System.Windows.Forms.GroupBox grpDica;
        private System.Windows.Forms.Label lblDica;
        private System.Windows.Forms.GroupBox grpJogo;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txbLetra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTentativasRestantes;
        private System.Windows.Forms.TextBox txbPalavra;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
    }
}

