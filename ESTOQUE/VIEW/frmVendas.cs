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
    public partial class frmVendas : Form
    {
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

            CAMADAS.BLL.Venda bllVenda = new CAMADAS.BLL.Venda();
            dgvVendas.DataSource = "";
            dgvVendas.DataSource = bllVenda.Select(); 
        }

        private void limparCamposVenda()
        {
            lblVendaID.Text = "";
            dtpDataVenda.Value = Convert.ToDateTime(DateTime.Now.ToLongDateString());
            txtClienteID.Text = "0";
            cmbCliente.SelectedValue = 0; 

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
        }
    }
}
