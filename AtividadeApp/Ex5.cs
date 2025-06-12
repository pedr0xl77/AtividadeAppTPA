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
    public partial class frmEx5 : Form
    {
        public frmEx5()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double raio, area;
            raio = Convert.ToDouble(txtRaio.Text);
            area = Math.PI * Math.Pow(raio, 2);
            txtArea.Text = area.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtRaio.Clear();
            txtArea.Clear();
            txtRaio.Focus();

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            Hide();
            menu.Show();
        }
    }
}
