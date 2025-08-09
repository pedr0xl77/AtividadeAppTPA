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
    public partial class frmEx8 : Form
    {
        public frmEx8()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
           double popular, geral, arquibancada, cadeira, pubtotal
           string tipoing



           pubtotal = Convert.ToDouble(txtPubtotal.Text);
           
            
        }

        private void btnPopular_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            double pubtotal, popular, arquibancada, cadeira, geral;
            string tipoing;


            pubtotal = Convert.ToDouble(txtPubtotal.Text);
            tipoing = txtTipoing.Text;

            if (tipoing == "1") ;
            {
                popular = (pubtotal * 0.10) * 5;
                txtResultado.Text = popular.ToString();
            }

            if (tipoing == "2")
            {
                geral = (pubtotal * 0.50) * 10;
                txtResultado.Text = geral.ToString();
            }

            if (tipoing == "3")
            {
                arquibancada = (pubtotal * 0.30) * 20;
                txtResultado.Text = arquibancada.ToString();
            }

            if (tipoing == "4")
            {
                cadeira = (pubtotal * 0.10) * 30;
                txtResultado.Text = cadeira.ToString();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPubtotal.Clear();
            txtResultado.Clear();
            txtTipoing.Clear();
            txtPubtotal.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            Hide();
            menu.Show();
        }
    }
}
