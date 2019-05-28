namespace ESTOQUE.VIEW
{
    partial class frmVendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnNovaVenda = new System.Windows.Forms.Button();
            this.btnCancelarVenda = new System.Windows.Forms.Button();
            this.btnGravarVenda = new System.Windows.Forms.Button();
            this.txtClienteID = new System.Windows.Forms.TextBox();
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.dtpDataVenda = new System.Windows.Forms.DateTimePicker();
            this.lblVendaID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVenda = new System.Windows.Forms.Label();
            this.BtnCancelItem = new System.Windows.Forms.Button();
            this.btnGrvItem = new System.Windows.Forms.Button();
            this.brnNovoItem = new System.Windows.Forms.Button();
            this.cmbProd = new System.Windows.Forms.ComboBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.txtProdID = new System.Windows.Forms.TextBox();
            this.lblItemVendaID = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvItemVenda = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Silver;
            this.splitContainer1.Panel1.Controls.Add(this.btnNovaVenda);
            this.splitContainer1.Panel1.Controls.Add(this.btnCancelarVenda);
            this.splitContainer1.Panel1.Controls.Add(this.btnGravarVenda);
            this.splitContainer1.Panel1.Controls.Add(this.txtClienteID);
            this.splitContainer1.Panel1.Controls.Add(this.dgvVendas);
            this.splitContainer1.Panel1.Controls.Add(this.cmbCliente);
            this.splitContainer1.Panel1.Controls.Add(this.dtpDataVenda);
            this.splitContainer1.Panel1.Controls.Add(this.lblVendaID);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.splitContainer1.Panel2.Controls.Add(this.lblVenda);
            this.splitContainer1.Panel2.Controls.Add(this.BtnCancelItem);
            this.splitContainer1.Panel2.Controls.Add(this.btnGrvItem);
            this.splitContainer1.Panel2.Controls.Add(this.brnNovoItem);
            this.splitContainer1.Panel2.Controls.Add(this.cmbProd);
            this.splitContainer1.Panel2.Controls.Add(this.txtValor);
            this.splitContainer1.Panel2.Controls.Add(this.txtQtde);
            this.splitContainer1.Panel2.Controls.Add(this.txtProdID);
            this.splitContainer1.Panel2.Controls.Add(this.lblItemVendaID);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.dgvItemVenda);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1344, 733);
            this.splitContainer1.SplitterDistance = 319;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnNovaVenda
            // 
            this.btnNovaVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaVenda.Location = new System.Drawing.Point(39, 213);
            this.btnNovaVenda.Name = "btnNovaVenda";
            this.btnNovaVenda.Size = new System.Drawing.Size(151, 44);
            this.btnNovaVenda.TabIndex = 11;
            this.btnNovaVenda.Text = "&Novo";
            this.btnNovaVenda.UseVisualStyleBackColor = true;
            this.btnNovaVenda.Click += new System.EventHandler(this.btnNovaVenda_Click);
            // 
            // btnCancelarVenda
            // 
            this.btnCancelarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarVenda.Location = new System.Drawing.Point(353, 213);
            this.btnCancelarVenda.Name = "btnCancelarVenda";
            this.btnCancelarVenda.Size = new System.Drawing.Size(151, 44);
            this.btnCancelarVenda.TabIndex = 9;
            this.btnCancelarVenda.Text = "&Cancelar";
            this.btnCancelarVenda.UseVisualStyleBackColor = true;
            this.btnCancelarVenda.Click += new System.EventHandler(this.btnCancelarVenda_Click);
            // 
            // btnGravarVenda
            // 
            this.btnGravarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravarVenda.Location = new System.Drawing.Point(196, 213);
            this.btnGravarVenda.Name = "btnGravarVenda";
            this.btnGravarVenda.Size = new System.Drawing.Size(151, 44);
            this.btnGravarVenda.TabIndex = 8;
            this.btnGravarVenda.Text = "&Gravar";
            this.btnGravarVenda.UseVisualStyleBackColor = true;
            this.btnGravarVenda.Click += new System.EventHandler(this.btnGravarVenda_Click);
            // 
            // txtClienteID
            // 
            this.txtClienteID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteID.Location = new System.Drawing.Point(154, 162);
            this.txtClienteID.Name = "txtClienteID";
            this.txtClienteID.Size = new System.Drawing.Size(137, 34);
            this.txtClienteID.TabIndex = 6;
            this.txtClienteID.TextChanged += new System.EventHandler(this.txtClienteID_TextChanged);
            this.txtClienteID.Leave += new System.EventHandler(this.txtClienteID_Leave);
            // 
            // dgvVendas
            // 
            this.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendas.Location = new System.Drawing.Point(660, 75);
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.RowTemplate.Height = 24;
            this.dgvVendas.Size = new System.Drawing.Size(639, 193);
            this.dgvVendas.TabIndex = 7;
            this.dgvVendas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVendas_CellContentClick);
            this.dgvVendas.DoubleClick += new System.EventHandler(this.dgvVendas_DoubleClick);
            // 
            // cmbCliente
            // 
            this.cmbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(297, 162);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(302, 37);
            this.cmbCliente.TabIndex = 7;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            // 
            // dtpDataVenda
            // 
            this.dtpDataVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataVenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataVenda.Location = new System.Drawing.Point(154, 97);
            this.dtpDataVenda.Name = "dtpDataVenda";
            this.dtpDataVenda.Size = new System.Drawing.Size(173, 34);
            this.dtpDataVenda.TabIndex = 5;
            // 
            // lblVendaID
            // 
            this.lblVendaID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendaID.Location = new System.Drawing.Point(149, 46);
            this.lblVendaID.Name = "lblVendaID";
            this.lblVendaID.Size = new System.Drawing.Size(107, 23);
            this.lblVendaID.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(516, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vendas de Produtos";
            // 
            // lblVenda
            // 
            this.lblVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenda.Location = new System.Drawing.Point(228, 99);
            this.lblVenda.Name = "lblVenda";
            this.lblVenda.Size = new System.Drawing.Size(100, 23);
            this.lblVenda.TabIndex = 16;
            // 
            // BtnCancelItem
            // 
            this.BtnCancelItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelItem.Location = new System.Drawing.Point(387, 318);
            this.BtnCancelItem.Name = "BtnCancelItem";
            this.BtnCancelItem.Size = new System.Drawing.Size(140, 80);
            this.BtnCancelItem.TabIndex = 15;
            this.BtnCancelItem.Text = "Cancelar Item";
            this.BtnCancelItem.UseVisualStyleBackColor = true;
            // 
            // btnGrvItem
            // 
            this.btnGrvItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrvItem.Location = new System.Drawing.Point(222, 318);
            this.btnGrvItem.Name = "btnGrvItem";
            this.btnGrvItem.Size = new System.Drawing.Size(140, 80);
            this.btnGrvItem.TabIndex = 14;
            this.btnGrvItem.Text = "Gravar Item";
            this.btnGrvItem.UseVisualStyleBackColor = true;
            this.btnGrvItem.Click += new System.EventHandler(this.btnGrvItem_Click);
            // 
            // brnNovoItem
            // 
            this.brnNovoItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnNovoItem.Location = new System.Drawing.Point(62, 318);
            this.brnNovoItem.Name = "brnNovoItem";
            this.brnNovoItem.Size = new System.Drawing.Size(140, 80);
            this.brnNovoItem.TabIndex = 13;
            this.brnNovoItem.Text = "Novo Item";
            this.brnNovoItem.UseVisualStyleBackColor = true;
            this.brnNovoItem.Click += new System.EventHandler(this.brnNovoItem_Click);
            // 
            // cmbProd
            // 
            this.cmbProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProd.FormattingEnabled = true;
            this.cmbProd.Location = new System.Drawing.Point(326, 134);
            this.cmbProd.Name = "cmbProd";
            this.cmbProd.Size = new System.Drawing.Size(285, 37);
            this.cmbProd.TabIndex = 12;
            this.cmbProd.SelectedIndexChanged += new System.EventHandler(this.cmbProd_SelectedIndexChanged);
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(220, 216);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(142, 34);
            this.txtValor.TabIndex = 11;
            // 
            // txtQtde
            // 
            this.txtQtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtde.Location = new System.Drawing.Point(220, 176);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(100, 34);
            this.txtQtde.TabIndex = 10;
            // 
            // txtProdID
            // 
            this.txtProdID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdID.Location = new System.Drawing.Point(220, 136);
            this.txtProdID.Name = "txtProdID";
            this.txtProdID.Size = new System.Drawing.Size(100, 34);
            this.txtProdID.TabIndex = 9;
            this.txtProdID.Leave += new System.EventHandler(this.txtProdID_Leave);
            // 
            // lblItemVendaID
            // 
            this.lblItemVendaID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemVendaID.Location = new System.Drawing.Point(223, 57);
            this.lblItemVendaID.Name = "lblItemVendaID";
            this.lblItemVendaID.Size = new System.Drawing.Size(104, 23);
            this.lblItemVendaID.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(106, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 29);
            this.label10.TabIndex = 6;
            this.label10.Text = "Valor R$:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(73, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 29);
            this.label9.TabIndex = 5;
            this.label9.Text = "Quantidade:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(113, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 29);
            this.label8.TabIndex = 4;
            this.label8.Text = "Produto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(129, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 29);
            this.label7.TabIndex = 3;
            this.label7.Text = "Venda:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "ID Item Venda:";
            // 
            // dgvItemVenda
            // 
            this.dgvItemVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemVenda.Location = new System.Drawing.Point(653, 162);
            this.dgvItemVenda.Name = "dgvItemVenda";
            this.dgvItemVenda.RowTemplate.Height = 24;
            this.dgvItemVenda.Size = new System.Drawing.Size(666, 228);
            this.dgvItemVenda.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(579, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Itens da Venda";
            // 
            // frmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 733);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Realizar Vendas de Produtos";
            this.Load += new System.EventHandler(this.frmVendas_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemVenda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnCancelarVenda;
        private System.Windows.Forms.Button btnGravarVenda;
        private System.Windows.Forms.TextBox txtClienteID;
        private System.Windows.Forms.DataGridView dgvVendas;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.DateTimePicker dtpDataVenda;
        private System.Windows.Forms.Label lblVendaID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNovaVenda;
        private System.Windows.Forms.Button BtnCancelItem;
        private System.Windows.Forms.Button btnGrvItem;
        private System.Windows.Forms.Button brnNovoItem;
        private System.Windows.Forms.ComboBox cmbProd;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.TextBox txtProdID;
        private System.Windows.Forms.Label lblItemVendaID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvItemVenda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblVenda;
    }
}