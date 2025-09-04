using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeApp
{
    public partial class frmEx6 : Form
    {
        public frmEx6()
        {
            InitializeComponent();
        }

        private void frmEx6_Load(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            string nome, sexo;
            int idade, salario, result = 0;

            nome = txtNome.Text;
            sexo = txtSexo.Text;
            idade = int.Parse(txtIdade.Text);
            salario = int.Parse(txtSalario.Text);

            if (sexo == "m" || sexo == "Masculino" || sexo == "masculino") 
            {
                if (idade >= 30) 
                    result = salario + 100;
                else
                    result = salario + 50;
            }
            else
            {
                if (idade >= 30)
                    result = salario + 250;
                else
                    result = salario + 150;
            }

            txtResposta.Text = "Ola " + nome +" seu salario atualizado é " + result.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtIdade.Clear();
            txtSexo.Clear();
            txtSalario.Clear();
            txtResposta.Clear();
            txtNome.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            Hide();
            menu.Show();
        }
    }
}
