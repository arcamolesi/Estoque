using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESTOQUE.Relatorios
{
    public partial class frmRelProd : Form
    {
        public frmRelProd()
        {
            InitializeComponent();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            int qtde = Convert.ToInt32(txtQtde.Text);
            int tipo=0;
            if (rdbNome.Checked)
                tipo = 1;
            else tipo = 2;
            Relatorios.relProdutos.relGeralProdutos(qtde, tipo); 
        }
    }
}
