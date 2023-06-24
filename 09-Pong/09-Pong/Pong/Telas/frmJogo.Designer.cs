namespace Pong.Telas
{
    partial class frmJogo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJogo));
            this.picBolinha = new System.Windows.Forms.PictureBox();
            this.picRaquete = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBolinha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRaquete)).BeginInit();
            this.SuspendLayout();
            // 
            // picBolinha
            // 
            this.picBolinha.Image = global::Pong.Properties.Resources.bola;
            this.picBolinha.Location = new System.Drawing.Point(12, 12);
            this.picBolinha.Name = "picBolinha";
            this.picBolinha.Size = new System.Drawing.Size(30, 30);
            this.picBolinha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBolinha.TabIndex = 0;
            this.picBolinha.TabStop = false;
            // 
            // picRaquete
            // 
            this.picRaquete.BackColor = System.Drawing.Color.Black;
            this.picRaquete.Location = new System.Drawing.Point(768, 140);
            this.picRaquete.Name = "picRaquete";
            this.picRaquete.Size = new System.Drawing.Size(13, 170);
            this.picRaquete.TabIndex = 1;
            this.picRaquete.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.picRaquete);
            this.Controls.Add(this.picBolinha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmJogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong";
            this.Load += new System.EventHandler(this.frmJogo_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmJogo_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picBolinha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRaquete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBolinha;
        private System.Windows.Forms.PictureBox picRaquete;
        private System.Windows.Forms.Timer timer1;
    }
}