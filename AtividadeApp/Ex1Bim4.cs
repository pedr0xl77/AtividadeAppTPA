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
    public partial class frmEx1Bim4 : Form
    {
        public frmEx1Bim4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResp.Clear();
            txtNum.Clear();
            txtNum.Focus();
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            int i,x,y;
            x = Convert.ToInt32(txtNum.Text);
            i = 1;
            do
            {
                y = i * x;
                txtResp.Text += " " + y.ToString();
                i++;
            }
            while (i < 11);
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            int i, x, y;
            x = Convert.ToInt32(txtNum.Text);
            i = 1;
            while (i < 11)
            {
                y = i * x;
                txtResp.Text += " " + y.ToString();
                i++;
            }
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            int i, x, y;
            x = Convert.ToInt32(txtNum.Text);
            
            for (i = 1; i < 11; i++)
            {
                y = i * x;
                txtResp.Text += " " + y.ToString();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Hide();
            frmMenu menu = new frmMenu();
            menu.Show();
        }
    }
}
