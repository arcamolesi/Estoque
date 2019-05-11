using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESTOQUE
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CAMADAS.DAL.Cliente dalClientes = new CAMADAS.DAL.Cliente();
            dgvClientes.DataSource = "";
            dgvClientes.DataSource = dalClientes.Select();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Cliente cliente = new CAMADAS.MODEL.Cliente();
            cliente.nome = txtNome.Text;
            cliente.aniversario = Convert.ToDateTime(txtAniversario.Text);
            cliente.telefone = txtTelefone.Text;

            CAMADAS.DAL.Cliente dalCli = new CAMADAS.DAL.Cliente();
            dalCli.Insert(cliente);

            dgvClientes.DataSource = "";
            dgvClientes.DataSource = dalCli.Select();

            txtNome.Text = "";
            txtAniversario.Text = "";
            txtTelefone.Text = "";
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Cliente cliente = new CAMADAS.MODEL.Cliente();
            cliente.id = Convert.ToInt32(lblId.Text);
            cliente.nome = txtNome.Text;
            cliente.aniversario = Convert.ToDateTime(txtAniversario.Text);
            cliente.telefone = txtTelefone.Text;

            CAMADAS.DAL.Cliente dalCli = new CAMADAS.DAL.Cliente();
            dalCli.Update(cliente);

            dgvClientes.DataSource = "";
            dgvClientes.DataSource = dalCli.Select();

            lblId.Text = "";
            txtNome.Text = "";
            txtAniversario.Text = "";
            txtTelefone.Clear();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvClientes_DoubleClick(object sender, EventArgs e)
        {
            lblId.Text = dgvClientes.SelectedRows[0].Cells["id"].Value.ToString();
            txtNome.Text = dgvClientes.SelectedRows[0].Cells["nome"].Value.ToString();
            txtAniversario.Text = dgvClientes.SelectedRows[0].Cells["aniversario"].Value.ToString();
            txtTelefone.Text = dgvClientes.SelectedRows[0].Cells["telefone"].Value.ToString();
        }

        private void BtnRemover_Click(object sender, EventArgs e)
            {
            if (lblId.Text != "")
            {
                int id = Convert.ToInt32(lblId.Text);
                CAMADAS.DAL.Cliente dalCli = new CAMADAS.DAL.Cliente();
                dalCli.Delete(id);

                dgvClientes.DataSource = "";
                dgvClientes.DataSource = dalCli.Select();

                lblId.Text = "";
                txtNome.Text = "";
                txtAniversario.Text = "";
                txtTelefone.Text = "";
            }
            else MessageBox.Show("Não há registros a remover...");
        }
    }
}
