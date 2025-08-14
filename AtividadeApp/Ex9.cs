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
    public partial class frmEx9 : Form
    {
        public frmEx9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double livro, valor;

            livro = Convert.ToDouble(txtLivro.Text);
            if (livro > 10 )
            {
                valor = livro * 8;
                txtValor.Text = valor.ToString();
            }
            else
            {
                valor = livro * 12;
                txtValor.Text = valor.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtLivro.Clear();
            txtValor.Clear();
            txtLivro.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            Hide();
            menu.Show();
        }
    }
}
