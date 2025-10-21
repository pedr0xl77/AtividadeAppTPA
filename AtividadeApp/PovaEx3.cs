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
    public partial class frmPovaEx3 : Form
    {
        public frmPovaEx3()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valor, vd;
            int codigo;

            valor = Convert.ToDouble(txtValor.Text);
            codigo = Convert.ToInt32(txtCodigo.Text);

            switch (codigo)  {}
        }
    }
}
