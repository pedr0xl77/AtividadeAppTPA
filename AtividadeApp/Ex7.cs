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
    public partial class frmEx7 : Form
    {
        public frmEx7()
        {
            InitializeComponent();
        }

        private void Ex7_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double largura, altura, area;
            largura = Convert.ToDouble(txtLargura.Text);
            altura = Convert.ToDouble(txtAltura.Text);
            area = largura * altura;
            txtArea.Text = area.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLargura.Clear();
            txtAltura.Clear();
            txtArea.Clear();
            txtLargura.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            Hide();
            menu.Show();
        }
    }
}
