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
    public partial class frmEx10 : Form
    {
        public frmEx10()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Double peso, altura, imc;

            peso = Convert.ToDouble(txtPeso.Text);
            altura = Convert.ToDouble(txtAltura.Text);

            imc = peso / (altura * altura);


            if (imc < 17)
            {
                txtResposta.Text = ("seu IMC é: " + imc.ToString() + " voce esta com magreza severa");
            }
            
            if (imc >= 17 && imc < 18.5)
            {
                txtResposta.Text = ("seu IMC é: " + imc.ToString() + " voce esta com magreza leve");
            }
            
            if (imc >= 18.5 && imc < 25)
            {
                txtResposta.Text = ("seu IMC é: " + imc.ToString() + " voce esta com o peso normal");
            }
            
            if (imc >= 25 && imc < 30)
            {
                txtResposta.Text = ("seu IMC é: " + imc.ToString() + " voce esta com sobrepeso ");
            }
            
            if (imc >= 30 && imc < 35)
            {
                txtResposta.Text = ("seu IMC é: " + imc.ToString() + " voce esta com obesidade classe 1");
            }
            
            if (imc >= 35 && imc < 40)
            {
                txtResposta.Text = ("seu IMC é: " + imc.ToString() + " voce esta com obesidade classe 2");
            }
            
        
            if (imc >= 40)
            {
                txtResposta.Text = ("seu IMC é: " + imc.ToString() + " voce esta com obesidade classe 3");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPeso.Clear();
            txtAltura.Clear();
            txtResposta.Clear();
            txtPeso.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Hide();
            frmMenu menu = new frmMenu();
            menu.Show();
        }
    }
}