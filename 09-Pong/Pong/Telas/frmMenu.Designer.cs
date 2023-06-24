namespace Pong
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.btnBasico = new System.Windows.Forms.Button();
            this.btnIntermediario = new System.Windows.Forms.Button();
            this.btnAvancado = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 105);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione seu nível de jogo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBasico
            // 
            this.btnBasico.BackColor = System.Drawing.Color.Yellow;
            this.btnBasico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBasico.Location = new System.Drawing.Point(47, 255);
            this.btnBasico.Name = "btnBasico";
            this.btnBasico.Size = new System.Drawing.Size(156, 42);
            this.btnBasico.TabIndex = 2;
            this.btnBasico.Text = "Básico";
            this.btnBasico.UseVisualStyleBackColor = false;
            this.btnBasico.Click += new System.EventHandler(this.btnBasico_Click);
            // 
            // btnIntermediario
            // 
            this.btnIntermediario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnIntermediario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntermediario.Location = new System.Drawing.Point(47, 303);
            this.btnIntermediario.Name = "btnIntermediario";
            this.btnIntermediario.Size = new System.Drawing.Size(156, 42);
            this.btnIntermediario.TabIndex = 3;
            this.btnIntermediario.Text = "Intermediário";
            this.btnIntermediario.UseVisualStyleBackColor = false;
            this.btnIntermediario.Click += new System.EventHandler(this.btnIntermediario_Click);
            // 
            // btnAvancado
            // 
            this.btnAvancado.BackColor = System.Drawing.Color.Red;
            this.btnAvancado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvancado.Location = new System.Drawing.Point(47, 351);
            this.btnAvancado.Name = "btnAvancado";
            this.btnAvancado.Size = new System.Drawing.Size(156, 42);
            this.btnAvancado.TabIndex = 4;
            this.btnAvancado.Text = "Avançado";
            this.btnAvancado.UseVisualStyleBackColor = false;
            this.btnAvancado.Click += new System.EventHandler(this.btnAvancado_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pong.Properties.Resources.bola_grande;
            this.pictureBox1.Location = new System.Drawing.Point(76, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 412);
            this.Controls.Add(this.btnAvancado);
            this.Controls.Add(this.btnIntermediario);
            this.Controls.Add(this.btnBasico);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBasico;
        private System.Windows.Forms.Button btnIntermediario;
        private System.Windows.Forms.Button btnAvancado;
    }
}

