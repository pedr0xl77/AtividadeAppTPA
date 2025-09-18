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
    public partial class frmProvaEx1 : Form
    {
        public frmProvaEx1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3, ME, MA;
            int aluno;

            aluno = Convert.ToInt32(txtAluno.Text);
            nota1 = Convert.ToDouble(txtNota1.Text);
            nota2 = Convert.ToDouble(txtNota2.Text);
            nota3 = Convert.ToDouble(txtNota3.Text);
            ME = Convert.ToInt32(txtME.Text);

            MA = (nota1 + nota2 * 2 + nota3 * 3 + ME) / 7;

            if(MA >= 90)
            {
                txtResposta.Text = "O Aluno " + aluno.ToString() + "ficou com uma média de " + MA.ToString() + " recebendo A sendo aprovado";
            }
            
            if (MA >= 75 && MA < 90)
            {
                txtResposta.Text = "O Aluno " + aluno.ToString() + "ficou com uma média de " + MA.ToString() + " recebendo B sendo aprovado";
            }

            if (MA >= 60 && MA < 75)
            {
                txtResposta.Text = "O Aluno " + aluno.ToString() + "ficou com uma média de " + MA.ToString() + " recebendo C sendo aprovado";
            }

            if (MA >= 40 && MA < 60)
            {
                txtResposta.Text = "O Aluno " + aluno.ToString() + "ficou com uma média de " + MA.ToString() + " recebendo D sendo reprovado";
            }

            if (MA < 40)
            {
                txtResposta.Text = "O Aluno " + aluno.ToString() + "ficou com uma média de " + MA.ToString() + " recebendo E sendo reprovado";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtME.Clear();
            txtAluno.Clear();
            txtResposta.Clear();
            txtNota1.Focus();
        }
    }
}
