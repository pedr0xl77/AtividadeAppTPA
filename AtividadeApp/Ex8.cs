using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace AtividadeApp
{
    public partial class frmEx8 : Form
    {
        public frmEx8()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
              double popular, geral, arquibancada, cadeiras, totpubl, rdp = 0, rda = 0, rdc = 0, rdg = 0, rendatot;

                totpubl = Convert.ToDouble(txtPubtotal.Text);

            popular = totpubl * 0.10;
            geral = totpubl * 0.50;
            arquibancada = totpubl * 0.30;
            cadeiras = totpubl * 0.10;

            if (popular > 0)
            {
                rdp = popular * 5;
            }

            if (geral > 0)
            {
                rdg = geral * 10;
            }

            if(arquibancada > 0)
            {
                rda = arquibancada * 20;
            }

            if (cadeiras > 0)
            {
                rdc = popular * 30;

            }
            rendatot = rdp + rdg + rda + rdc;

            txtResultado.Text = rendatot.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPubtotal.Clear();
            txtResultado.Clear();
            txtPubtotal.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            Hide();
            menu.Show();
        }
    }
}
