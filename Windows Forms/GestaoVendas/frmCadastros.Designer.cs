namespace GestaoVendas
{
    partial class frmCadastros
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
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.lbl_Cpf = new System.Windows.Forms.Label();
            this.lbl_Telefone = new System.Windows.Forms.Label();
            this.lbl_Endereco = new System.Windows.Forms.Label();
            this.lbl_Cidade = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.tb_Nome = new System.Windows.Forms.TextBox();
            this.tb_Cpf = new System.Windows.Forms.TextBox();
            this.tb_Telefone = new System.Windows.Forms.TextBox();
            this.tb_Endereco = new System.Windows.Forms.TextBox();
            this.tb_Cidade = new System.Windows.Forms.TextBox();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.btn_CadastrarCliente = new System.Windows.Forms.Button();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.dgv_Clientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CpfCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefoneCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnderecoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CidadeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_IdCliente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Location = new System.Drawing.Point(4, 47);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_Nome.TabIndex = 1;
            this.lbl_Nome.Text = "Nome";
            // 
            // lbl_Cpf
            // 
            this.lbl_Cpf.AutoSize = true;
            this.lbl_Cpf.Location = new System.Drawing.Point(4, 73);
            this.lbl_Cpf.Name = "lbl_Cpf";
            this.lbl_Cpf.Size = new System.Drawing.Size(27, 13);
            this.lbl_Cpf.TabIndex = 2;
            this.lbl_Cpf.Text = "CPF";
            // 
            // lbl_Telefone
            // 
            this.lbl_Telefone.AutoSize = true;
            this.lbl_Telefone.Location = new System.Drawing.Point(4, 99);
            this.lbl_Telefone.Name = "lbl_Telefone";
            this.lbl_Telefone.Size = new System.Drawing.Size(49, 13);
            this.lbl_Telefone.TabIndex = 3;
            this.lbl_Telefone.Text = "Telefone";
            // 
            // lbl_Endereco
            // 
            this.lbl_Endereco.AutoSize = true;
            this.lbl_Endereco.Location = new System.Drawing.Point(4, 125);
            this.lbl_Endereco.Name = "lbl_Endereco";
            this.lbl_Endereco.Size = new System.Drawing.Size(53, 13);
            this.lbl_Endereco.TabIndex = 4;
            this.lbl_Endereco.Text = "Endereço";
            // 
            // lbl_Cidade
            // 
            this.lbl_Cidade.AutoSize = true;
            this.lbl_Cidade.Location = new System.Drawing.Point(4, 151);
            this.lbl_Cidade.Name = "lbl_Cidade";
            this.lbl_Cidade.Size = new System.Drawing.Size(40, 13);
            this.lbl_Cidade.TabIndex = 5;
            this.lbl_Cidade.Text = "Cidade";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(7, 177);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(32, 13);
            this.lbl_Email.TabIndex = 6;
            this.lbl_Email.Text = "Email";
            // 
            // tb_Nome
            // 
            this.tb_Nome.Location = new System.Drawing.Point(68, 47);
            this.tb_Nome.Name = "tb_Nome";
            this.tb_Nome.Size = new System.Drawing.Size(140, 20);
            this.tb_Nome.TabIndex = 8;
            // 
            // tb_Cpf
            // 
            this.tb_Cpf.Location = new System.Drawing.Point(68, 73);
            this.tb_Cpf.Name = "tb_Cpf";
            this.tb_Cpf.Size = new System.Drawing.Size(140, 20);
            this.tb_Cpf.TabIndex = 9;
            // 
            // tb_Telefone
            // 
            this.tb_Telefone.Location = new System.Drawing.Point(68, 99);
            this.tb_Telefone.Name = "tb_Telefone";
            this.tb_Telefone.Size = new System.Drawing.Size(140, 20);
            this.tb_Telefone.TabIndex = 10;
            // 
            // tb_Endereco
            // 
            this.tb_Endereco.Location = new System.Drawing.Point(68, 125);
            this.tb_Endereco.Name = "tb_Endereco";
            this.tb_Endereco.Size = new System.Drawing.Size(140, 20);
            this.tb_Endereco.TabIndex = 11;
            // 
            // tb_Cidade
            // 
            this.tb_Cidade.Location = new System.Drawing.Point(68, 151);
            this.tb_Cidade.Name = "tb_Cidade";
            this.tb_Cidade.Size = new System.Drawing.Size(140, 20);
            this.tb_Cidade.TabIndex = 12;
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(68, 177);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(140, 20);
            this.tb_Email.TabIndex = 13;
            // 
            // btn_CadastrarCliente
            // 
            this.btn_CadastrarCliente.Location = new System.Drawing.Point(7, 231);
            this.btn_CadastrarCliente.Name = "btn_CadastrarCliente";
            this.btn_CadastrarCliente.Size = new System.Drawing.Size(140, 35);
            this.btn_CadastrarCliente.TabIndex = 17;
            this.btn_CadastrarCliente.Text = "Cadastrar Cliente";
            this.btn_CadastrarCliente.UseVisualStyleBackColor = true;
            this.btn_CadastrarCliente.Click += new System.EventHandler(this.btn_CadastrarCliente_Click);
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(7, 288);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(140, 35);
            this.btn_Voltar.TabIndex = 18;
            this.btn_Voltar.Text = "Voltar ";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // dgv_Clientes
            // 
            this.dgv_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.NomeCliente,
            this.CpfCliente,
            this.TelefoneCliente,
            this.EnderecoCliente,
            this.CidadeCliente,
            this.EmailCliente});
            this.dgv_Clientes.Enabled = false;
            this.dgv_Clientes.Location = new System.Drawing.Point(214, 21);
            this.dgv_Clientes.Name = "dgv_Clientes";
            this.dgv_Clientes.Size = new System.Drawing.Size(662, 302);
            this.dgv_Clientes.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "ID Cliente";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID Cliente";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // NomeCliente
            // 
            this.NomeCliente.HeaderText = "Nome";
            this.NomeCliente.Name = "NomeCliente";
            // 
            // CpfCliente
            // 
            this.CpfCliente.HeaderText = "Cpf";
            this.CpfCliente.Name = "CpfCliente";
            this.CpfCliente.Width = 70;
            // 
            // TelefoneCliente
            // 
            this.TelefoneCliente.HeaderText = "Telefone";
            this.TelefoneCliente.Name = "TelefoneCliente";
            this.TelefoneCliente.Width = 70;
            // 
            // EnderecoCliente
            // 
            this.EnderecoCliente.HeaderText = "Endereço";
            this.EnderecoCliente.Name = "EnderecoCliente";
            this.EnderecoCliente.Width = 150;
            // 
            // CidadeCliente
            // 
            this.CidadeCliente.HeaderText = "Cidade";
            this.CidadeCliente.Name = "CidadeCliente";
            this.CidadeCliente.Width = 80;
            // 
            // EmailCliente
            // 
            this.EmailCliente.HeaderText = "Email";
            this.EmailCliente.Name = "EmailCliente";
            // 
            // tb_IdCliente
            // 
            this.tb_IdCliente.Location = new System.Drawing.Point(68, 21);
            this.tb_IdCliente.Name = "tb_IdCliente";
            this.tb_IdCliente.Size = new System.Drawing.Size(140, 20);
            this.tb_IdCliente.TabIndex = 21;
            // 
            // frmCadastros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 450);
            this.Controls.Add(this.tb_IdCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.btn_CadastrarCliente);
            this.Controls.Add(this.dgv_Clientes);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.tb_Cidade);
            this.Controls.Add(this.tb_Endereco);
            this.Controls.Add(this.tb_Telefone);
            this.Controls.Add(this.tb_Cpf);
            this.Controls.Add(this.tb_Nome);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_Cidade);
            this.Controls.Add(this.lbl_Endereco);
            this.Controls.Add(this.lbl_Telefone);
            this.Controls.Add(this.lbl_Cpf);
            this.Controls.Add(this.lbl_Nome);
            this.Name = "frmCadastros";
            this.Text = "frmCadastros";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label lbl_Cpf;
        private System.Windows.Forms.Label lbl_Telefone;
        private System.Windows.Forms.Label lbl_Endereco;
        private System.Windows.Forms.Label lbl_Cidade;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox tb_Nome;
        private System.Windows.Forms.TextBox tb_Cpf;
        private System.Windows.Forms.TextBox tb_Telefone;
        private System.Windows.Forms.TextBox tb_Endereco;
        private System.Windows.Forms.TextBox tb_Cidade;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.Button btn_CadastrarCliente;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.DataGridView dgv_Clientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CpfCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefoneCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnderecoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CidadeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_IdCliente;
    }
}