namespace GestaoVendas
{
    partial class frm_ItemVenda
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_IdCliente = new System.Windows.Forms.TextBox();
            this.tb_IdVenda = new System.Windows.Forms.TextBox();
            this.tb_IdProduto = new System.Windows.Forms.TextBox();
            this.tb_ValorUnitario = new System.Windows.Forms.TextBox();
            this.tb_Quantidade = new System.Windows.Forms.TextBox();
            this.tb_TotalVenda = new System.Windows.Forms.TextBox();
            this.dgv_ItemVenda = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_GravarVenda = new System.Windows.Forms.Button();
            this.btn_Voltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ItemVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Venda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID Prodruto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor Unitario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total da Venda";
            // 
            // tb_IdCliente
            // 
            this.tb_IdCliente.Location = new System.Drawing.Point(99, 12);
            this.tb_IdCliente.Name = "tb_IdCliente";
            this.tb_IdCliente.Size = new System.Drawing.Size(100, 20);
            this.tb_IdCliente.TabIndex = 6;
            // 
            // tb_IdVenda
            // 
            this.tb_IdVenda.Location = new System.Drawing.Point(99, 38);
            this.tb_IdVenda.Name = "tb_IdVenda";
            this.tb_IdVenda.Size = new System.Drawing.Size(100, 20);
            this.tb_IdVenda.TabIndex = 7;
            // 
            // tb_IdProduto
            // 
            this.tb_IdProduto.Location = new System.Drawing.Point(99, 64);
            this.tb_IdProduto.Name = "tb_IdProduto";
            this.tb_IdProduto.Size = new System.Drawing.Size(100, 20);
            this.tb_IdProduto.TabIndex = 8;
            // 
            // tb_ValorUnitario
            // 
            this.tb_ValorUnitario.Location = new System.Drawing.Point(99, 90);
            this.tb_ValorUnitario.Name = "tb_ValorUnitario";
            this.tb_ValorUnitario.Size = new System.Drawing.Size(100, 20);
            this.tb_ValorUnitario.TabIndex = 9;
            // 
            // tb_Quantidade
            // 
            this.tb_Quantidade.Location = new System.Drawing.Point(99, 116);
            this.tb_Quantidade.Name = "tb_Quantidade";
            this.tb_Quantidade.Size = new System.Drawing.Size(100, 20);
            this.tb_Quantidade.TabIndex = 10;
            // 
            // tb_TotalVenda
            // 
            this.tb_TotalVenda.Location = new System.Drawing.Point(99, 143);
            this.tb_TotalVenda.Name = "tb_TotalVenda";
            this.tb_TotalVenda.Size = new System.Drawing.Size(100, 20);
            this.tb_TotalVenda.TabIndex = 11;
            // 
            // dgv_ItemVenda
            // 
            this.dgv_ItemVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ItemVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgv_ItemVenda.Location = new System.Drawing.Point(223, 12);
            this.dgv_ItemVenda.Name = "dgv_ItemVenda";
            this.dgv_ItemVenda.Size = new System.Drawing.Size(544, 163);
            this.dgv_ItemVenda.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID Cliente";
            this.Column1.Name = "Column1";
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ID Venda";
            this.Column2.Name = "Column2";
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ID Produto";
            this.Column3.Name = "Column3";
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Valor Unitário";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Quantidade";
            this.Column5.Name = "Column5";
            this.Column5.Width = 80;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Total da Venda";
            this.Column6.Name = "Column6";
            this.Column6.Width = 80;
            // 
            // btn_GravarVenda
            // 
            this.btn_GravarVenda.Location = new System.Drawing.Point(7, 193);
            this.btn_GravarVenda.Name = "btn_GravarVenda";
            this.btn_GravarVenda.Size = new System.Drawing.Size(99, 23);
            this.btn_GravarVenda.TabIndex = 13;
            this.btn_GravarVenda.Text = "Gravar Venda";
            this.btn_GravarVenda.UseVisualStyleBackColor = true;
            this.btn_GravarVenda.Click += new System.EventHandler(this.btn_GravarVenda_Click);
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(112, 193);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(99, 23);
            this.btn_Voltar.TabIndex = 14;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            // 
            // frm_ItemVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 450);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.btn_GravarVenda);
            this.Controls.Add(this.dgv_ItemVenda);
            this.Controls.Add(this.tb_TotalVenda);
            this.Controls.Add(this.tb_Quantidade);
            this.Controls.Add(this.tb_ValorUnitario);
            this.Controls.Add(this.tb_IdProduto);
            this.Controls.Add(this.tb_IdVenda);
            this.Controls.Add(this.tb_IdCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_ItemVenda";
            this.Text = "frm_ItemVenda";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ItemVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_IdCliente;
        private System.Windows.Forms.TextBox tb_IdVenda;
        private System.Windows.Forms.TextBox tb_IdProduto;
        private System.Windows.Forms.TextBox tb_ValorUnitario;
        private System.Windows.Forms.TextBox tb_Quantidade;
        private System.Windows.Forms.TextBox tb_TotalVenda;
        private System.Windows.Forms.DataGridView dgv_ItemVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btn_GravarVenda;
        private System.Windows.Forms.Button btn_Voltar;
    }
}