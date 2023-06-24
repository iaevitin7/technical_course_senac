using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnBasico_Click(object sender, EventArgs e)
        {
            Telas.frmJogo Jogo = new Telas.frmJogo(200, 10);
            Jogo.ShowDialog();
        }

        private void btnIntermediario_Click(object sender, EventArgs e)
        {
            Telas.frmJogo Jogo = new Telas.frmJogo(100, 15);
            Jogo.ShowDialog();
        }

        private void btnAvancado_Click(object sender, EventArgs e)
        {
            Telas.frmJogo Jogo = new Telas.frmJogo(50, 20);
            Jogo.ShowDialog();
        }
    }
}
