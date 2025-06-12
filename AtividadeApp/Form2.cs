using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeApp
{
    public partial class frmEx2 : Form
    {
        public frmEx2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double tempo, vel, dist, LU;
            tempo = Convert.ToDouble(txtTempo.Text);
            vel = Convert.ToDouble(txtVel.Text);
            dist = tempo * vel;
            LU = dist / 12;
            txtDist.Text = dist.ToString();
            txtLU.Text = LU.ToString();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTempo.Clear();
            txtVel.Clear();
            txtDist.Clear();
            txtLU.Clear();
            txtTempo.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            Hide();
            menu.Show();
        }
    }
}
