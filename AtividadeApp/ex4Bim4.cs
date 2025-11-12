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
    public partial class frmEx4Bim4 : Form
    {
        int i = 0;
        int[] a = new int[15];
        int[] b = new int[15];

        public frmEx4Bim4()
        {
            InitializeComponent();
        }
            
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num;
            num = Convert.ToInt32(txtNumeros.Text);

            if (i<=13)
            {
                txtNumeros.Clear();
                txtNumeros.Focus();
            }


            if (i <= 14) 
            {
                a[i] = num;
                b[i] = a[i] * a[i];
                txtResposta.Text = Convert.ToString(b[i]);
                i++;
            }

            if (i == 15)
            {
                btnCalcular.Text = "calcular";
                txtNumeros.Enabled = false;
            }

            if(i>15)
            {
                MessageBox.Show("O vetor ja esta cheio");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumeros.Clear();
            txtResposta.Clear();
            txtNumeros.Focus();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Hide();
            frmMenu menu = new frmMenu();
            menu.Show();
        }

        private void txtResposta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumeros_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
