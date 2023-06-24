using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComponentesBasicos
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // Popula a ComboBox
            comboBox1.Items.AddRange(new string[] { "Item 4", "Item 5", "Item 6" });

            // Popula a ListBox
            listBox1.Items.AddRange(new string[] { "Item 1", "Item 2", "Item 3" });

            // Configura o listView
            listView1.View = View.Details;
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.None);

            // Adiciona colunas à ListView
            listView1.Columns.Add("Nome", 50);
            listView1.Columns.Add("Idade", 50);

            // Popula a ListView
            listView1.Items.Add(new ListViewItem(new string[] { "João", "30" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Maria", "25" }));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = comboBox1.SelectedItem.ToString();
            lblComboBox.Text = "Selecionou: " + item;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string list = listBox1.SelectedItem.ToString();
            lblListBox.Text = "Selecionou: " + list;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string nome = selectedItem.SubItems[0].Text;
                string idade = selectedItem.SubItems[1].Text;
                lblListView.Text = "Selecionou: " + nome + ", " + idade;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                lblRadioButton.Text = "Opção A Selecionada";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                lblRadioButton.Text = "Opção B Selecionada";
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string telefone = maskedTextBox1.Text;
            lblMask.Text = "Fone: " + telefone;

            string data = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            lblData.Text = "Data selecionada: " + data;

            if (checkBox1.Checked)
            {
                lblCheck.Text = "Opção selecionada";
            }
            else
            {
                lblCheck.Text = "Opção não selecionada";
            }

            string texto = txbTexto.Text;
            lblTexto.Text = "Olá " + texto + "\nBem vindo ao Windows Forms";

            pictureBox1.Image = Properties.Resources.smurf;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
