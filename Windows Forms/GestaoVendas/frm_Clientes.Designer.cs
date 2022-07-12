namespace GestaoVendas
{
    partial class frm_Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Clientes));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgv_Clientes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_MostarClientes = new System.Windows.Forms.Button();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.btn_CadastrarCliente = new System.Windows.Forms.Button();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.tb_Cidade = new System.Windows.Forms.TextBox();
            this.tb_Endereco = new System.Windows.Forms.TextBox();
            this.tb_Telefone = new System.Windows.Forms.TextBox();
            this.tb_Cpf = new System.Windows.Forms.TextBox();
            this.tb_Nome = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Cidade = new System.Windows.Forms.Label();
            this.lbl_Endereco = new System.Windows.Forms.Label();
            this.lbl_Telefone = new System.Windows.Forms.Label();
            this.lbl_Cpf = new System.Windows.Forms.Label();
            this.lbl_Nome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(929, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dgv_Clientes
            // 
            this.dgv_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgv_Clientes.Location = new System.Drawing.Point(318, 12);
            this.dgv_Clientes.Name = "dgv_Clientes";
            this.dgv_Clientes.Size = new System.Drawing.Size(599, 417);
            this.dgv_Clientes.TabIndex = 40;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nome";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cpf";
            this.Column2.Name = "Column2";
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Telefone";
            this.Column3.Name = "Column3";
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Endereço";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Cidade";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Email";
            this.Column6.Name = "Column6";
            // 
            // btn_MostarClientes
            // 
            this.btn_MostarClientes.Location = new System.Drawing.Point(38, 333);
            this.btn_MostarClientes.Name = "btn_MostarClientes";
            this.btn_MostarClientes.Size = new System.Drawing.Size(137, 23);
            this.btn_MostarClientes.TabIndex = 39;
            this.btn_MostarClientes.Text = "Mostrar Clientes";
            this.btn_MostarClientes.UseVisualStyleBackColor = true;
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(35, 284);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(140, 35);
            this.btn_Voltar.TabIndex = 38;
            this.btn_Voltar.Text = "Voltar ";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            // 
            // btn_CadastrarCliente
            // 
            this.btn_CadastrarCliente.Location = new System.Drawing.Point(35, 227);
            this.btn_CadastrarCliente.Name = "btn_CadastrarCliente";
            this.btn_CadastrarCliente.Size = new System.Drawing.Size(140, 35);
            this.btn_CadastrarCliente.TabIndex = 37;
            this.btn_CadastrarCliente.Text = "Cadastrar Cliente";
            this.btn_CadastrarCliente.UseVisualStyleBackColor = true;
            this.btn_CadastrarCliente.Click += new System.EventHandler(this.btn_CadastrarCliente_Click_1);
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(96, 173);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(140, 20);
            this.tb_Email.TabIndex = 36;
            // 
            // tb_Cidade
            // 
            this.tb_Cidade.Location = new System.Drawing.Point(96, 147);
            this.tb_Cidade.Name = "tb_Cidade";
            this.tb_Cidade.Size = new System.Drawing.Size(140, 20);
            this.tb_Cidade.TabIndex = 35;
            // 
            // tb_Endereco
            // 
            this.tb_Endereco.Location = new System.Drawing.Point(96, 121);
            this.tb_Endereco.Name = "tb_Endereco";
            this.tb_Endereco.Size = new System.Drawing.Size(140, 20);
            this.tb_Endereco.TabIndex = 34;
            // 
            // tb_Telefone
            // 
            this.tb_Telefone.Location = new System.Drawing.Point(96, 95);
            this.tb_Telefone.Name = "tb_Telefone";
            this.tb_Telefone.Size = new System.Drawing.Size(140, 20);
            this.tb_Telefone.TabIndex = 33;
            // 
            // tb_Cpf
            // 
            this.tb_Cpf.Location = new System.Drawing.Point(96, 69);
            this.tb_Cpf.Name = "tb_Cpf";
            this.tb_Cpf.Size = new System.Drawing.Size(140, 20);
            this.tb_Cpf.TabIndex = 32;
            // 
            // tb_Nome
            // 
            this.tb_Nome.Location = new System.Drawing.Point(96, 43);
            this.tb_Nome.Name = "tb_Nome";
            this.tb_Nome.Size = new System.Drawing.Size(140, 20);
            this.tb_Nome.TabIndex = 31;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(35, 173);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(32, 13);
            this.lbl_Email.TabIndex = 30;
            this.lbl_Email.Text = "Email";
            // 
            // lbl_Cidade
            // 
            this.lbl_Cidade.AutoSize = true;
            this.lbl_Cidade.Location = new System.Drawing.Point(32, 147);
            this.lbl_Cidade.Name = "lbl_Cidade";
            this.lbl_Cidade.Size = new System.Drawing.Size(40, 13);
            this.lbl_Cidade.TabIndex = 29;
            this.lbl_Cidade.Text = "Cidade";
            // 
            // lbl_Endereco
            // 
            this.lbl_Endereco.AutoSize = true;
            this.lbl_Endereco.Location = new System.Drawing.Point(32, 121);
            this.lbl_Endereco.Name = "lbl_Endereco";
            this.lbl_Endereco.Size = new System.Drawing.Size(53, 13);
            this.lbl_Endereco.TabIndex = 28;
            this.lbl_Endereco.Text = "Endereço";
            // 
            // lbl_Telefone
            // 
            this.lbl_Telefone.AutoSize = true;
            this.lbl_Telefone.Location = new System.Drawing.Point(32, 95);
            this.lbl_Telefone.Name = "lbl_Telefone";
            this.lbl_Telefone.Size = new System.Drawing.Size(49, 13);
            this.lbl_Telefone.TabIndex = 27;
            this.lbl_Telefone.Text = "Telefone";
            // 
            // lbl_Cpf
            // 
            this.lbl_Cpf.AutoSize = true;
            this.lbl_Cpf.Location = new System.Drawing.Point(32, 69);
            this.lbl_Cpf.Name = "lbl_Cpf";
            this.lbl_Cpf.Size = new System.Drawing.Size(27, 13);
            this.lbl_Cpf.TabIndex = 26;
            this.lbl_Cpf.Text = "CPF";
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Location = new System.Drawing.Point(32, 43);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_Nome.TabIndex = 25;
            this.lbl_Nome.Text = "Nome";
            // 
            // frm_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 450);
            this.Controls.Add(this.dgv_Clientes);
            this.Controls.Add(this.btn_MostarClientes);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.btn_CadastrarCliente);
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
            this.Controls.Add(this.pictureBox1);
            this.Name = "frm_Clientes";
            this.Text = "Cadastro de Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgv_Clientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btn_MostarClientes;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Button btn_CadastrarCliente;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.TextBox tb_Cidade;
        private System.Windows.Forms.TextBox tb_Endereco;
        private System.Windows.Forms.TextBox tb_Telefone;
        private System.Windows.Forms.TextBox tb_Cpf;
        private System.Windows.Forms.TextBox tb_Nome;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Cidade;
        private System.Windows.Forms.Label lbl_Endereco;
        private System.Windows.Forms.Label lbl_Telefone;
        private System.Windows.Forms.Label lbl_Cpf;
        private System.Windows.Forms.Label lbl_Nome;
        
    }
}