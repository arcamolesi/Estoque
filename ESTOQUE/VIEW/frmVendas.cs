using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; 

namespace ESTOQUE.VIEW
{
    public partial class frmVendas : Form
    {
        public CAMADAS.MODEL.Produto produto { get; set; }

        public frmVendas()
        {
            InitializeComponent();
        }

        private void frmVendas_Load(object sender, EventArgs e)
        {
            //configurar Caixa Combo Cliente
            CAMADAS.DAL.Cliente dalCli = new CAMADAS.DAL.Cliente();
            cmbCliente.DisplayMember = "nome";
            cmbCliente.ValueMember = "id";
            cmbCliente.DataSource = dalCli.Select();

            //Carregar Combo Produtos
            CAMADAS.BLL.Produto bllProd = new CAMADAS.BLL.Produto();
            cmbProd.DisplayMember = "descricao";
            cmbProd.ValueMember = "id";
            cmbProd.DataSource = bllProd.Select(); 

            //carregar Datagridview de Vendas
            CAMADAS.BLL.Venda bllVenda = new CAMADAS.BLL.Venda();
            dgvVendas.DataSource = "";
            List<CAMADAS.MODEL.Venda> listaVenda = new List<CAMADAS.MODEL.Venda>();
            listaVenda = bllVenda.Select();
            dgvVendas.DataSource = listaVenda;

            //carregar datagridview ItemVenda
            CAMADAS.BLL.ItemVenda bllItemVenda = new CAMADAS.BLL.ItemVenda();
            dgvItemVenda.DataSource = "";
            dgvItemVenda.DataSource = bllItemVenda.Select(); 

        }

        private void limparCamposVenda()
        {
            lblVendaID.Text = "";
            dtpDataVenda.Value = Convert.ToDateTime(DateTime.Now.ToLongDateString());
            txtClienteID.Text = "0";
            cmbCliente.SelectedValue = 0; 
        }

        private void limparCamposItemVenda()
        {
            lblItemVendaID.Text = "";
            lblVenda.Text = "";
            txtProdID.Text = "0";
            txtQtde.Text = "";
            txtValor.Text = "";
            cmbProd.SelectedValue = 0; 
        }

        void recuperaProduto(int idProd)
        {
            CAMADAS.BLL.Produto bllProd = new CAMADAS.BLL.Produto();
            List<CAMADAS.MODEL.Produto> lstProdutos = bllProd.SelectById(idProd);
            if (lstProdutos != null)
                produto = lstProdutos[0];
            else produto = null; 
        }

        void calculaTotal()
        {   
            //operador ternário do if
            float qtde = (txtQtde.Text == string.Empty) ? 0 : Convert.ToSingle(txtQtde.Text);
            float valor = (txtValor.Text == string.Empty) ? 0 : Convert.ToSingle(txtValor.Text);
            float total = qtde * valor;
            //lblTotal.Text = total.ToString(); 
            lblTotal.Text = string.Format("{0:0.00}",total);
        }


        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNovaVenda_Click(object sender, EventArgs e)
        {
            limparCamposVenda();
            lblVendaID.Text = "-1";
            dtpDataVenda.Focus(); 
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtClienteID.Text = cmbCliente.SelectedValue.ToString();
            }
            catch {}
           
        }

        private void txtClienteID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cmbCliente.SelectedValue = Convert.ToInt32(txtClienteID.Text);
            }
            catch { }
        }

        private void txtClienteID_Leave(object sender, EventArgs e)
        {
            try
            {
                cmbCliente.SelectedValue = Convert.ToInt32(txtClienteID.Text);
            }
            catch { }
        }

        private void btnCancelarVenda_Click(object sender, EventArgs e)
        {
            limparCamposVenda(); 
        }

        private void btnGravarVenda_Click(object sender, EventArgs e)
        {
            CAMADAS.BLL.Venda bllVenda = new CAMADAS.BLL.Venda(); 
            int id = Convert.ToInt32(lblVendaID.Text);
            if (id == -1)
            {
                CAMADAS.MODEL.Venda venda = new CAMADAS.MODEL.Venda();
                venda.id = id;
                venda.data = dtpDataVenda.Value;
                venda.cliente = Convert.ToInt32(cmbCliente.SelectedValue.ToString());
                bllVenda.Insert(venda); 
            }
            dgvVendas.DataSource = "";
            dgvVendas.DataSource = bllVenda.Select();
            limparCamposVenda(); 
        }

        private void dgvVendas_DoubleClick(object sender, EventArgs e)
        {
            lblVendaID.Text = dgvVendas.SelectedRows[0].Cells["id"].Value.ToString();
            dtpDataVenda.Value = Convert.ToDateTime(dgvVendas.SelectedRows[0].Cells["data"].Value.ToString());
            cmbCliente.SelectedValue = Convert.ToInt32(dgvVendas.SelectedRows[0].Cells["cliente"].Value.ToString());

            // recuperando itens da venda
            CAMADAS.BLL.ItemVenda bllItmVenda = new CAMADAS.BLL.ItemVenda(); 
            int idVenda = Convert.ToInt32(lblVendaID.Text);
            dgvItemVenda.DataSource = "";
            dgvItemVenda.DataSource = bllItmVenda.SelectByIDVenda(idVenda); 

        }

        private void dgvVendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void brnNovoItem_Click(object sender, EventArgs e)
        {
            int idVenda = (lblVendaID.Text == string.Empty) ? 0 : Convert.ToInt32(lblVendaID.Text);
            if (idVenda > 0)
            {
                limparCamposItemVenda();
                lblItemVendaID.Text = "-1";
                lblVenda.Text = lblVendaID.Text;
                txtProdID.Focus();
            }
            else MessageBox.Show("Não há Venda Selecionada"); 
        }

        private void txtProdID_Leave(object sender, EventArgs e)
        {
            try
            {
                cmbCliente.SelectedValue = Convert.ToInt32(txtProdID.Text); 
            }
            catch 
            {
               
            }
        }

        private void cmbProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                txtProdID.Text = cmbProd.SelectedValue.ToString();
            }
            catch { }
        }

        private void btnGrvItem_Click(object sender, EventArgs e)
        {
            CAMADAS.BLL.ItemVenda bllItemVenda = new CAMADAS.BLL.ItemVenda();
            CAMADAS.MODEL.ItemVenda itemvenda = new CAMADAS.MODEL.ItemVenda();
            if (lblItemVendaID.Text == "-1")
            {

                itemvenda.id = Convert.ToInt32(lblItemVendaID.Text);
                itemvenda.venda = Convert.ToInt32(lblVendaID.Text);
                itemvenda.produto = Convert.ToInt32(txtProdID.Text);
                itemvenda.quantidade = Convert.ToSingle(txtQtde.Text);
                itemvenda.valor = Convert.ToSingle(txtValor.Text);
                bllItemVenda.Insert(itemvenda); 
            }
            limparCamposItemVenda();
            dgvItemVenda.DataSource = ""; 
            dgvItemVenda.DataSource = bllItemVenda.SelectByIDVenda(itemvenda.venda);
            
        }

        private void BtnCancelItem_Click(object sender, EventArgs e)
        {
           
        }

        private void cmbProd_Leave(object sender, EventArgs e)
        {
            int idProd = Convert.ToInt32(cmbProd.SelectedValue);
            recuperaProduto(idProd);
            if (produto != null)
                txtValor.Text = produto.valor.ToString(); 
        }

        private void txtQtde_Leave(object sender, EventArgs e)
        {
            if (produto != null)
            {
                float qtde = Convert.ToSingle(txtQtde.Text);
                if (qtde > produto.quantidade)
                    MessageBox.Show("Quantidade Insuficiente: " + produto.quantidade.ToString());
                calculaTotal(); 
            }
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            calculaTotal(); 
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            try {
                calculaTotal();
            }
            catch { }
        }
    }
}
