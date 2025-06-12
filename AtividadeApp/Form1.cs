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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void mstiSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mstiEx1_Click(object sender, EventArgs e)
        {
            frmEx1 ex1 = new frmEx1();
            Hide();
            ex1.Show();
        }

        private void mstiEx2_Click(object sender, EventArgs e)
        {
            frmEx2 ex2 = new frmEx2();
            Hide();
            ex2.Show();
        }

        private void mstiEx3_Click(object sender, EventArgs e)
        {
            frmEx3 ex3 = new frmEx3();
            Hide();
            ex3.Show();
        }

        private void mstiEx4_Click(object sender, EventArgs e)
        {
            frmEx4 ex4 = new frmEx4();
            Hide();
            ex4.Show();
        }

        private void mstiEx5_Click(object sender, EventArgs e)
        {
            frmEx5 ex5 = new frmEx5();
            Hide();
            ex5.Show();
        }

      

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
