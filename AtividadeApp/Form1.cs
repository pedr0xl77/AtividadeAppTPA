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


        private void frmMenu_Load(object sender, EventArgs e)
        {

        }



        private void exercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEx1 ex1 = new frmEx1();
            Hide();
            ex1.Show();
        }

        private void exercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEx2 ex2 = new frmEx2();
            Hide();
            ex2.Show();
        }

        private void exercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEx3 ex3 = new frmEx3();
            Hide();
            ex3.Show();
        }

        private void exercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEx4 ex4 = new frmEx4();
            Hide();
            ex4.Show();
        }

        private void exercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEx5 ex5 = new frmEx5();
            Hide();
            ex5.Show();
        }

        private void exercicio6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEx6 ex6 = new frmEx6();
            Hide();
            ex6.Show();
        }

        private void exercicio7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEx7 ex7 = new frmEx7();
            Hide();
            ex7.Show();
        }

        private void exercicio8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEx8 ex8 = new frmEx8();
            Hide();
            ex8.Show();
        }

        private void exercicio9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEx9 ex9 = new frmEx9();
            Hide();
            ex9.Show();

        }

        private void exercicio10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEx10 ex10 = new frmEx10();
            Hide();
            ex10.Show();
        }

        private void exercicio11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            frmEx11 ex11 = new frmEx11();
            ex11.Show();
            
        }

        private void prova3BimestreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ex1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            frmProvaEx1 ProvaEx1 = new frmProvaEx1();
            ProvaEx1.Show();
        }

        private void eX1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hide();
            frmEx1Bim4 ex1 = new frmEx1Bim4();
            ex1.Show();
        }

        private void eX2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hide();
            frmEx2Bim4 ex2 = new frmEx2Bim4();
            ex2.Show();
        }
    }


}
