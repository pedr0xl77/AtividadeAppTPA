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
    public partial class frmEx1 : Form
    {
        public frmEx1()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            Hide();
            menu.Show();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double tempC, tempF;

            tempC = Convert.ToDouble(txtTempC.Text);

            tempF = (tempC * 1.8) + 32;

            txtTempF.Text = tempF.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTempC.Clear();
            txtTempF.Clear();
            txtTempC.Focus();
        }

        private void frmEx1_Load(object sender, EventArgs e)
        {

        }
    }
}
