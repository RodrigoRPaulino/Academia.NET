namespace GestaoVendas
{
    partial class frm_Vendas
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
            this.btn_RegistrarVenda = new System.Windows.Forms.Button();
            this.lbl_TotalVenda = new System.Windows.Forms.Label();
            this.lbl_IdVenda = new System.Windows.Forms.Label();
            this.lbl_IdProduto = new System.Windows.Forms.Label();
            this.tb_IdCliente = new System.Windows.Forms.TextBox();
            this.tb_IdVenda = new System.Windows.Forms.TextBox();
            this.tb_TotalVenda = new System.Windows.Forms.TextBox();
            this.dgv_Vendas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Vendas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_RegistrarVenda
            // 
            this.btn_RegistrarVenda.Location = new System.Drawing.Point(4, 152);
            this.btn_RegistrarVenda.Name = "btn_RegistrarVenda";
            this.btn_RegistrarVenda.Size = new System.Drawing.Size(103, 23);
            this.btn_RegistrarVenda.TabIndex = 12;
            this.btn_RegistrarVenda.Text = "Registrar Venda";
            this.btn_RegistrarVenda.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_RegistrarVenda.UseVisualStyleBackColor = true;
            this.btn_RegistrarVenda.Click += new System.EventHandler(this.btn_RegistrarVenda_Click);
            // 
            // lbl_TotalVenda
            // 
            this.lbl_TotalVenda.AutoSize = true;
            this.lbl_TotalVenda.Location = new System.Drawing.Point(-4, 83);
            this.lbl_TotalVenda.Name = "lbl_TotalVenda";
            this.lbl_TotalVenda.Size = new System.Drawing.Size(80, 13);
            this.lbl_TotalVenda.TabIndex = 5;
            this.lbl_TotalVenda.Text = "Total da Venda";
            // 
            // lbl_IdVenda
            // 
            this.lbl_IdVenda.AutoSize = true;
            this.lbl_IdVenda.Location = new System.Drawing.Point(9, 30);
            this.lbl_IdVenda.Name = "lbl_IdVenda";
            this.lbl_IdVenda.Size = new System.Drawing.Size(50, 13);
            this.lbl_IdVenda.TabIndex = 1;
            this.lbl_IdVenda.Text = "Id Venda";
            // 
            // lbl_IdProduto
            // 
            this.lbl_IdProduto.AutoSize = true;
            this.lbl_IdProduto.Location = new System.Drawing.Point(1, 57);
            this.lbl_IdProduto.Name = "lbl_IdProduto";
            this.lbl_IdProduto.Size = new System.Drawing.Size(56, 13);
            this.lbl_IdProduto.TabIndex = 0;
            this.lbl_IdProduto.Text = "Id Produto";
            // 
            // tb_IdCliente
            // 
            this.tb_IdCliente.Location = new System.Drawing.Point(89, 57);
            this.tb_IdCliente.Name = "tb_IdCliente";
            this.tb_IdCliente.Size = new System.Drawing.Size(100, 20);
            this.tb_IdCliente.TabIndex = 6;
            // 
            // tb_IdVenda
            // 
            this.tb_IdVenda.Location = new System.Drawing.Point(89, 30);
            this.tb_IdVenda.Name = "tb_IdVenda";
            this.tb_IdVenda.Size = new System.Drawing.Size(100, 20);
            this.tb_IdVenda.TabIndex = 7;
            // 
            // tb_TotalVenda
            // 
            this.tb_TotalVenda.Location = new System.Drawing.Point(89, 83);
            this.tb_TotalVenda.Name = "tb_TotalVenda";
            this.tb_TotalVenda.Size = new System.Drawing.Size(100, 20);
            this.tb_TotalVenda.TabIndex = 11;
            // 
            // dgv_Vendas
            // 
            this.dgv_Vendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Vendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column6});
            this.dgv_Vendas.Location = new System.Drawing.Point(195, 30);
            this.dgv_Vendas.Name = "dgv_Vendas";
            this.dgv_Vendas.Size = new System.Drawing.Size(345, 209);
            this.dgv_Vendas.TabIndex = 13;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID Venda";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ID Cliente";
            this.Column2.Name = "Column2";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Total da Venda";
            this.Column6.Name = "Column6";
            // 
            // frmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 486);
            this.Controls.Add(this.dgv_Vendas);
            this.Controls.Add(this.btn_RegistrarVenda);
            this.Controls.Add(this.tb_TotalVenda);
            this.Controls.Add(this.tb_IdVenda);
            this.Controls.Add(this.tb_IdCliente);
            this.Controls.Add(this.lbl_TotalVenda);
            this.Controls.Add(this.lbl_IdVenda);
            this.Controls.Add(this.lbl_IdProduto);
            this.Name = "frmVendas";
            this.Text = "Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Vendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_RegistrarVenda;
        private System.Windows.Forms.Label lbl_TotalVenda;
        private System.Windows.Forms.Label lbl_IdVenda;
        private System.Windows.Forms.Label lbl_IdProduto;
        private System.Windows.Forms.TextBox tb_IdCliente;
        private System.Windows.Forms.TextBox tb_IdVenda;
        private System.Windows.Forms.TextBox tb_TotalVenda;
        private System.Windows.Forms.DataGridView dgv_Vendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}