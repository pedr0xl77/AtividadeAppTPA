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
    public partial class frmEx6Bim4 : Form
    {
        int i = 0,j = 0;
        int[] a = new int[30];
        int[] b = new int[30];
        public frmEx6Bim4()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(txtPesquisar.Text);
            bool encontrado = false;

            for (int j = 0; j < i; j++)
            {
                if (b[j] == valor)
                {
                    MessageBox.Show($"Valor {valor} encontrado na posição {j} do vetor B!");
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado)
            {
                MessageBox.Show($"O valor {valor} não foi encontrado no vetor B.");
            }

            txtPesquisar.Clear();
            txtPesquisar.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void txtResposta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumeros_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num;
            num = Convert.ToInt32(txtNumeros.Text);

            if (i <= 28)
            {
                txtNumeros.Clear();
                txtNumeros.Focus();
            }


            if (i <= 29)
            {
                a[i] = num;
                b[i] = a[i] * a[i] * a[i];
                txtResposta.Text = Convert.ToString(b[i]);
                i++;
            }

            if (i == 30)
            {
                btnCalcular.Text = "calcular";
                txtNumeros.Enabled = false;
            }

            if (i > 30)
            {
                MessageBox.Show("O vetor ja esta cheio");
            }
        }
    }
}
