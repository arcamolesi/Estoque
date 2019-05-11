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
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void habilitaCampos(bool status)
        {
            txtDescricao.Enabled = status;
            txtQuantidade.Enabled = status;
            txtValor.Enabled = status;
            dgvProdutos.Enabled = status;

            btnInserir.Enabled = !status;
            btnEditar.Enabled = !status;
            btnRemover.Enabled = !status;
            btnGravar.Enabled = status;
            btnCancelar.Enabled = status;
            btnSair.Enabled = true;
        }

        private void limpaCampos()
        {
            lblId.Text = "";
            txtDescricao.Text = "";
            txtQuantidade.Text = string.Empty;  //"";
            txtValor.Clear();   //txt.Valor.Text = "";
        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {
            CAMADAS.DAL.Produto dalProd = new CAMADAS.DAL.Produto();
            dgvProdutos.DataSource = "";
            dgvProdutos.DataSource = dalProd.Select();

            habilitaCampos(false);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            limpaCampos();
            lblId.Text = "-1";
            habilitaCampos(true);
            txtDescricao.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Produto produto = new CAMADAS.MODEL.Produto();
            produto.id = Convert.ToInt32(lblId.Text);
            produto.descricao = txtDescricao.Text;
            produto.quantidade = Convert.ToSingle(txtQuantidade.Text);
            produto.valor = Convert.ToSingle(txtValor.Text);

            CAMADAS.DAL.Produto dalProd = new CAMADAS.DAL.Produto();
            dalProd.Update(produto);

            dgvProdutos.DataSource = "";
            dgvProdutos.DataSource = dalProd.Select();

            lblId.Text = "";
            txtDescricao.Text = "";
            txtQuantidade.Text = "";
            txtValor.Text = "";
        }

        private void dgvProdutos_DoubleClick(object sender, EventArgs e)
        {
            lblId.Text = dgvProdutos.SelectedRows[0].Cells["id"].Value.ToString();
            txtDescricao.Text = dgvProdutos.SelectedRows[0].Cells["descricao"].Value.ToString();
            txtQuantidade.Text = dgvProdutos.SelectedRows[0].Cells["quantidade"].Value.ToString();
            txtValor.Text = dgvProdutos.SelectedRows[0].Cells["valor"].Value.ToString();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            CAMADAS.DAL.Produto dalProd = new CAMADAS.DAL.Produto();
            CAMADAS.MODEL.Produto produto = new CAMADAS.MODEL.Produto();
            produto.id = Convert.ToInt32(lblId.Text);
            produto.descricao = txtDescricao.Text;
            produto.quantidade = Convert.ToSingle(txtQuantidade.Text);
            produto.valor = Convert.ToSingle(txtValor.Text);
            dalProd.Insert(produto);
            
            limpaCampos();
            habilitaCampos(false);

            dgvProdutos.DataSource = "";
            dgvProdutos.DataSource = dalProd.Select();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaCampos();
            habilitaCampos(false);
        }
    }
}
