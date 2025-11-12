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
    public partial class frmEx3BIm4 : Form
    {
        public frmEx3BIm4()
        {
            InitializeComponent();
        }
        int  comodo = 0, aTotal;
        DialogResult rspt = DialogResult.Yes;

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtComodo.Clear();
            txtComprimento.Clear();
            txtLargura.Clear();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int comprimento, largura;
            comprimento = Convert.ToInt32(txtComprimento.Text);
            largura = Convert.ToInt32(txtLargura.Text);
            comodo = largura * comprimento;
            aTotal += comodo;

            rspt = MessageBox.Show("Deseja adicionar outro cômodo?", "Continuar?", MessageBoxButtons.YesNo);
            if (rspt == DialogResult.Yes)
            {
                txtComprimento.Clear();
                txtLargura.Clear();
                txtComprimento.Focus();
            }
            else
            {
                lblComodo.Text = "Area Total:";
                txtComodo.Text = Convert.ToString(aTotal);
            }
                txtComodo.Text = Convert.ToString(comodo);
        }
    }
}
