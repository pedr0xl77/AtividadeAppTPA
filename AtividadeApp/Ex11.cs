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
    public partial class frmEx11 : Form
    {
        public frmEx11()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int op;
            string frase;

            op =  Convert.ToInt32(txtPedido.Text);

            switch(op)
            {
                case 100:
                    frase = "voce pediu o cachorro quente custando $25 a unidade";
                    txtResposta.Text = frase;
                break;

                case 101:
                    frase = "voce pediu o bauru custando $15 a unidade";
                    txtResposta.Text = frase;
                break;

                case 102:
                    frase = "voce pediu o X-Burguer custando $35 a unidade";
                    txtResposta.Text = frase;
                break;

                case 102:
                    frase = "voce pediu o Triple X-Burguer $47 a unidade";
                    txtResposta.Text = frase;
                break;
            }



        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPedido.Clear();
            txtResposta.Clear();
            txtPedido.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            Hide();
        }
    }
}
