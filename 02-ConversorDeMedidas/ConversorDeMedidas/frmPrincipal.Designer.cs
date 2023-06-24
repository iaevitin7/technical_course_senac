using System.Windows.Forms;

namespace ConversorDeMedidas
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGraus = new System.Windows.Forms.Button();
            this.txbCelsius = new System.Windows.Forms.TextBox();
            this.txbFahrenheit = new System.Windows.Forms.TextBox();
            this.txbResultado = new System.Windows.Forms.TextBox();
            this.txbCM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rdbMilimetros = new System.Windows.Forms.RadioButton();
            this.rdbPolegadas = new System.Windows.Forms.RadioButton();
            this.txbLibras = new System.Windows.Forms.TextBox();
            this.txbKg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPeso = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(36, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conversor de medidas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite os graus em Celsius:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Graus em Fahrenheit:";
            // 
            // btnGraus
            // 
            this.btnGraus.Location = new System.Drawing.Point(165, 107);
            this.btnGraus.Name = "btnGraus";
            this.btnGraus.Size = new System.Drawing.Size(64, 38);
            this.btnGraus.TabIndex = 3;
            this.btnGraus.Text = "Converter";
            this.btnGraus.UseVisualStyleBackColor = true;
            this.btnGraus.Click += new System.EventHandler(this.btnGraus_Click);
            // 
            // txbCelsius
            // 
            this.txbCelsius.Location = new System.Drawing.Point(14, 90);
            this.txbCelsius.Name = "txbCelsius";
            this.txbCelsius.Size = new System.Drawing.Size(86, 20);
            this.txbCelsius.TabIndex = 5;
            // 
            // txbFahrenheit
            // 
            this.txbFahrenheit.Location = new System.Drawing.Point(14, 147);
            this.txbFahrenheit.Name = "txbFahrenheit";
            this.txbFahrenheit.Size = new System.Drawing.Size(86, 20);
            this.txbFahrenheit.TabIndex = 6;
            // 
            // txbResultado
            // 
            this.txbResultado.Location = new System.Drawing.Point(14, 312);
            this.txbResultado.Name = "txbResultado";
            this.txbResultado.Size = new System.Drawing.Size(86, 20);
            this.txbResultado.TabIndex = 10;
            // 
            // txbCM
            // 
            this.txbCM.Location = new System.Drawing.Point(14, 255);
            this.txbCM.Name = "txbCM";
            this.txbCM.Size = new System.Drawing.Size(86, 20);
            this.txbCM.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Resultado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Digite a medida em CM:";
            // 
            // rdbMilimetros
            // 
            this.rdbMilimetros.AutoSize = true;
            this.rdbMilimetros.Location = new System.Drawing.Point(157, 274);
            this.rdbMilimetros.Name = "rdbMilimetros";
            this.rdbMilimetros.Size = new System.Drawing.Size(73, 17);
            this.rdbMilimetros.TabIndex = 11;
            this.rdbMilimetros.TabStop = true;
            this.rdbMilimetros.Text = "Milímetros";
            this.rdbMilimetros.UseVisualStyleBackColor = true;
            this.rdbMilimetros.CheckedChanged += new System.EventHandler(this.rdbMilimetros_CheckedChanged);
            // 
            // rdbPolegadas
            // 
            this.rdbPolegadas.AutoSize = true;
            this.rdbPolegadas.Location = new System.Drawing.Point(157, 296);
            this.rdbPolegadas.Name = "rdbPolegadas";
            this.rdbPolegadas.Size = new System.Drawing.Size(75, 17);
            this.rdbPolegadas.TabIndex = 12;
            this.rdbPolegadas.TabStop = true;
            this.rdbPolegadas.Text = "Polegadas";
            this.rdbPolegadas.UseVisualStyleBackColor = true;
            this.rdbPolegadas.CheckedChanged += new System.EventHandler(this.rdbPolegadas_CheckedChanged);
            // 
            // txbLibras
            // 
            this.txbLibras.Location = new System.Drawing.Point(14, 467);
            this.txbLibras.Name = "txbLibras";
            this.txbLibras.Size = new System.Drawing.Size(86, 20);
            this.txbLibras.TabIndex = 17;
            // 
            // txbKg
            // 
            this.txbKg.Location = new System.Drawing.Point(14, 410);
            this.txbKg.Name = "txbKg";
            this.txbKg.Size = new System.Drawing.Size(86, 20);
            this.txbKg.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 452);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Peso em Libras:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 392);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Digite o peso em Kg:";
            // 
            // btnPeso
            // 
            this.btnPeso.Location = new System.Drawing.Point(157, 426);
            this.btnPeso.Name = "btnPeso";
            this.btnPeso.Size = new System.Drawing.Size(64, 38);
            this.btnPeso.TabIndex = 18;
            this.btnPeso.Text = "Converter";
            this.btnPeso.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ConversorDeMedidas.Properties.Resources.balanca;
            this.pictureBox3.Location = new System.Drawing.Point(277, 410);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(86, 72);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ConversorDeMedidas.Properties.Resources.regua;
            this.pictureBox2.Location = new System.Drawing.Point(277, 255);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(86, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ConversorDeMedidas.Properties.Resources.temperatura;
            this.pictureBox1.Location = new System.Drawing.Point(277, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 510);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnPeso);
            this.Controls.Add(this.txbLibras);
            this.Controls.Add(this.txbKg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.rdbPolegadas);
            this.Controls.Add(this.rdbMilimetros);
            this.Controls.Add(this.txbResultado);
            this.Controls.Add(this.txbCM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbFahrenheit);
            this.Controls.Add(this.txbCelsius);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGraus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de medidas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnGraus;
        private PictureBox pictureBox1;
        private TextBox txbCelsius;
        private TextBox txbFahrenheit;
        private TextBox txbResultado;
        private TextBox txbCM;
        private Label label4;
        private Label label5;
        private RadioButton rdbMilimetros;
        private RadioButton rdbPolegadas;
        private PictureBox pictureBox2;
        private TextBox txbLibras;
        private TextBox txbKg;
        private Label label6;
        private Label label7;
        private Button btnPeso;
        private PictureBox pictureBox3;
    }
}