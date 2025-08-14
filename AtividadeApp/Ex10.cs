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
    public partial class frmEx10 : Form
    {
        public frmEx10()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double salario, valor, idade;
            string nome,sexo;

            nome = txtNome.Text;
            sexo = txtSexo.Text;
            idade = Convert.ToDouble(txtIdade.Text);
            salario = Convert.ToDouble(txtSalario.Text);

            if (sexo == "m" || sexo == "masculino" || sexo == "Masculino") 
            {
                if (idade > 30) 
                    valor = salario + 100;
                else
                    valor = salario + 50;
            }
            else
            {
                if (idade > 30)
                    valor = salario + 250;
                else
                    valor = salario + 150;
            }

            txtFala.Text = (nome + " voce tem " + idade.ToString() + " anos e recebe " + valor.ToString() + " reais");          
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtFala.Clear();
            txtIdade.Clear();
            txtNome.Clear();
            txtSalario.Clear();
            txtSexo.Clear();
            txtNome.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            Hide();
            menu.Show();
        }
    }
}
