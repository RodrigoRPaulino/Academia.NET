namespace GestaoVendas
{
    partial class frm_Produtos
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
            this.lbl_CodEAN = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Estoque = new System.Windows.Forms.Label();
            this.lbl_ValorProduto = new System.Windows.Forms.Label();
            this.tb_CodEAN = new System.Windows.Forms.TextBox();
            this.tb_NomeProduto = new System.Windows.Forms.TextBox();
            this.tb_Estoque = new System.Windows.Forms.TextBox();
            this.tb_ValorProduto = new System.Windows.Forms.TextBox();
            this.dgv_Produtos = new System.Windows.Forms.DataGridView();
            this.dgv_CodEAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_NomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_ValorProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_InserirProduto = new System.Windows.Forms.Button();
            this.btn_Voltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Produtos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_CodEAN
            // 
            this.lbl_CodEAN.AutoSize = true;
            this.lbl_CodEAN.Location = new System.Drawing.Point(4, 35);
            this.lbl_CodEAN.Name = "lbl_CodEAN";
            this.lbl_CodEAN.Size = new System.Drawing.Size(48, 13);
            this.lbl_CodEAN.TabIndex = 1;
            this.lbl_CodEAN.Text = "CodEAN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome do Produto";
            // 
            // lbl_Estoque
            // 
            this.lbl_Estoque.AutoSize = true;
            this.lbl_Estoque.Location = new System.Drawing.Point(4, 87);
            this.lbl_Estoque.Name = "lbl_Estoque";
            this.lbl_Estoque.Size = new System.Drawing.Size(46, 13);
            this.lbl_Estoque.TabIndex = 3;
            this.lbl_Estoque.Text = "Estoque";
            // 
            // lbl_ValorProduto
            // 
            this.lbl_ValorProduto.AutoSize = true;
            this.lbl_ValorProduto.Location = new System.Drawing.Point(4, 113);
            this.lbl_ValorProduto.Name = "lbl_ValorProduto";
            this.lbl_ValorProduto.Size = new System.Drawing.Size(86, 13);
            this.lbl_ValorProduto.TabIndex = 4;
            this.lbl_ValorProduto.Text = "Valor do Produto";
            // 
            // tb_CodEAN
            // 
            this.tb_CodEAN.Location = new System.Drawing.Point(124, 35);
            this.tb_CodEAN.Name = "tb_CodEAN";
            this.tb_CodEAN.Size = new System.Drawing.Size(127, 20);
            this.tb_CodEAN.TabIndex = 6;
            // 
            // tb_NomeProduto
            // 
            this.tb_NomeProduto.Location = new System.Drawing.Point(124, 61);
            this.tb_NomeProduto.Name = "tb_NomeProduto";
            this.tb_NomeProduto.Size = new System.Drawing.Size(127, 20);
            this.tb_NomeProduto.TabIndex = 7;
            // 
            // tb_Estoque
            // 
            this.tb_Estoque.Location = new System.Drawing.Point(124, 87);
            this.tb_Estoque.Name = "tb_Estoque";
            this.tb_Estoque.Size = new System.Drawing.Size(127, 20);
            this.tb_Estoque.TabIndex = 8;
            // 
            // tb_ValorProduto
            // 
            this.tb_ValorProduto.Location = new System.Drawing.Point(124, 113);
            this.tb_ValorProduto.Name = "tb_ValorProduto";
            this.tb_ValorProduto.Size = new System.Drawing.Size(127, 20);
            this.tb_ValorProduto.TabIndex = 9;
            // 
            // dgv_Produtos
            // 
            this.dgv_Produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Produtos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_CodEAN,
            this.dgv_NomeProduto,
            this.dgv_Estoque,
            this.dgv_ValorProduto});
            this.dgv_Produtos.Enabled = false;
            this.dgv_Produtos.Location = new System.Drawing.Point(257, 9);
            this.dgv_Produtos.Name = "dgv_Produtos";
            this.dgv_Produtos.Size = new System.Drawing.Size(445, 225);
            this.dgv_Produtos.TabIndex = 10;
            // 
            // dgv_CodEAN
            // 
            this.dgv_CodEAN.HeaderText = "CodEAN";
            this.dgv_CodEAN.Name = "dgv_CodEAN";
            // 
            // dgv_NomeProduto
            // 
            this.dgv_NomeProduto.HeaderText = "Nome do Produto";
            this.dgv_NomeProduto.Name = "dgv_NomeProduto";
            // 
            // dgv_Estoque
            // 
            this.dgv_Estoque.HeaderText = "Estoque";
            this.dgv_Estoque.Name = "dgv_Estoque";
            // 
            // dgv_ValorProduto
            // 
            this.dgv_ValorProduto.HeaderText = "Valor do Produto";
            this.dgv_ValorProduto.Name = "dgv_ValorProduto";
            // 
            // btn_InserirProduto
            // 
            this.btn_InserirProduto.Location = new System.Drawing.Point(7, 160);
            this.btn_InserirProduto.Name = "btn_InserirProduto";
            this.btn_InserirProduto.Size = new System.Drawing.Size(114, 23);
            this.btn_InserirProduto.TabIndex = 11;
            this.btn_InserirProduto.Text = "Inserir Produto";
            this.btn_InserirProduto.UseVisualStyleBackColor = true;
            this.btn_InserirProduto.Click += new System.EventHandler(this.btn_InserirProduto_Click);
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(12, 189);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(110, 23);
            this.btn_Voltar.TabIndex = 12;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.btn_InserirProduto);
            this.Controls.Add(this.dgv_Produtos);
            this.Controls.Add(this.tb_ValorProduto);
            this.Controls.Add(this.tb_Estoque);
            this.Controls.Add(this.tb_NomeProduto);
            this.Controls.Add(this.tb_CodEAN);
            this.Controls.Add(this.lbl_ValorProduto);
            this.Controls.Add(this.lbl_Estoque);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_CodEAN);
            this.Name = "frmProdutos";
            this.Text = "frmProdutos";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Produtos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_CodEAN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Estoque;
        private System.Windows.Forms.Label lbl_ValorProduto;
        private System.Windows.Forms.TextBox tb_CodEAN;
        private System.Windows.Forms.TextBox tb_NomeProduto;
        private System.Windows.Forms.TextBox tb_Estoque;
        private System.Windows.Forms.TextBox tb_ValorProduto;
        private System.Windows.Forms.DataGridView dgv_Produtos;
        private System.Windows.Forms.Button btn_InserirProduto;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_CodEAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_NomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Estoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_ValorProduto;
    }
}