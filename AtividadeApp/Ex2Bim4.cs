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
    public partial class frmEx2Bim4 : Form
    {
        public frmEx2Bim4()
        {
            InitializeComponent();
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            double c, f;
            int i = 0;
            do
            {
                c = i * 10;
                f = (c * 1.8) + 32;
                txtResp.Text += "celcius: " + c + "  fahrenheit: " + f + "\n";
                i++;
            }
            while (i < 10);
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            double c, f;
            int i = 0;

            while (i < 10)
            {
                c = i * 10;
                f = (c * 1.8) + 32;
                txtResp.Text += "celcius: " + c + "  fahrenheit: " + f + "\n";
                i++;
            }
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            double c, f;
            int i = 0;

            for(i=0;i<10;i++)
            {
                c = i * 10;
                f = (c * 1.8) + 32;
                txtResp.Text += "celcius: " + c + "  fahrenheit: " + f + "\n";
            }
        }
    }
}
