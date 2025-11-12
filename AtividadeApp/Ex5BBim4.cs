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
    public partial class frmEx5BBim4 : Form
    {
        int i = 0;
        int[] a = new int[10];
        int[] b = new int[10];

        public frmEx5BBim4()
        {
            InitializeComponent();
        }

        private void Ex5BBim4_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num;
            num = Convert.ToInt32(txtNumeros.Text);

            if (i <= 8)
            {
                txtNumeros.Clear();
                txtNumeros.Focus();
            }


            if (i <= 9)
            {
                a[i] = num;
                b[i] = a[i] * -1;
                txtResposta.Text = Convert.ToString(b[i]);
                i++;
            }

            if (i == 10)
            {
                btnCalcular.Text = "calcular";
                txtNumeros.Enabled = false;
            }

            if (i > 10)
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Hide();
            frmMenu menu = new frmMenu();
            menu.Show();
        }

    }
}
