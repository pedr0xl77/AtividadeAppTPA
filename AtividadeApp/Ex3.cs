using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeApp
{
    public partial class frmEx3 : Form
    {
        public frmEx3()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            double real, precoDolar, dolar;
            real = Convert.ToDouble(txtReal.Text);
            precoDolar = Convert.ToDouble(txtPrecoDolar.Text);
            dolar = real / precoDolar;
            txtUSD.Text = dolar.ToString();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtReal.Clear();
            txtPrecoDolar.Clear();
            txtUSD.Clear();
            txtReal.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            Hide();
            menu.Show();

        }
    }
}
