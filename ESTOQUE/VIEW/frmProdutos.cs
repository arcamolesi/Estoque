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
            dgvProdutos.Enabled = !status;

            btnInserir.Enabled = !status;
            btnEditar.Enabled = !status;
            btnRemover.Enabled = !status;
            btnGravar.Enabled = status;
           // btnCancelar.Enabled = status;
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
           
            CAMADAS.BLL.Produto bllProd = new CAMADAS.BLL.Produto(); 
            dgvProdutos.DataSource = "";
            dgvProdutos.DataSource = bllProd.Select();

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
             
            if (lblId.Text.Length>0)
            {
                habilitaCampos(true);
                txtDescricao.Focus();
            }
            else MessageBox.Show("Sem registros para editar", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
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
            CAMADAS.BLL.Produto bllProd = new CAMADAS.BLL.Produto(); 
            int id = Convert.ToInt32(lblId.Text);
            string texto, rotulo; 
            if (id < 0)
            {
               texto = "Confirma Inclusão?";
               rotulo = "Incluir";
            }
            else
            {
                texto = "Confirma Atualização?";
                rotulo = "Atualizar";
            }
            DialogResult result;
            result = MessageBox.Show(texto, rotulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                CAMADAS.MODEL.Produto produto = new CAMADAS.MODEL.Produto();
                produto.id = Convert.ToInt32(lblId.Text);
                produto.descricao = txtDescricao.Text;
                produto.quantidade = Convert.ToSingle(txtQuantidade.Text);
                produto.valor = Convert.ToSingle(txtValor.Text);

                if (id < 0)
                    bllProd.Insert(produto);
                else bllProd.Update(produto); 
            }
            else MessageBox.Show("Dados não gravados", rotulo, 
                                    MessageBoxButtons.OK ,MessageBoxIcon.Information); 
            limpaCampos();
            habilitaCampos(false);

            dgvProdutos.DataSource = "";
            dgvProdutos.DataSource = bllProd.Select();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaCampos();
            habilitaCampos(false);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (lblId.Text.Length > 0)
            {
                DialogResult result;
                result = MessageBox.Show("Confirma Remoção", "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                CAMADAS.BLL.Produto bllProd = new CAMADAS.BLL.Produto(); 
                if (result == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(lblId.Text);
                    bllProd.Delete(id); 
                }

                limpaCampos(); 
                dgvProdutos.DataSource = "";
                dgvProdutos.DataSource = bllProd.Select(); 

            }
        }
    }
}
