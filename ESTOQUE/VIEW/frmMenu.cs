using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESTOQUE.VIEW
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose(); 
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente frmCli = new frmCliente();
            frmCli.MdiParent = this; 
            frmCli.Show(); 
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProdutos frmProd = new FrmProdutos();
            frmProd.MdiParent = this;
            frmProd.Show(); 
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre frmSob = new frmSobre();
            frmSob.ShowDialog(); 
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVendas frmVen = new frmVendas();
            frmVen.MdiParent = this;
            frmVen.Show(); 
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Relatorios.relProdutos.relGeralProdutos(); 
        }

        private void produtoComFiltrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorios.frmRelProd frmRProd = new Relatorios.frmRelProd();
            frmRProd.MdiParent = this; 
            frmRProd.Show(); 
        }
    }
}
