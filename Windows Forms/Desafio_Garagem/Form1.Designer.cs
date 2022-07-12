namespace Desafio_Garagem
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_Placa = new System.Windows.Forms.Label();
            this.lbl_DataHoraEntrada = new System.Windows.Forms.Label();
            this.tb_Placa = new System.Windows.Forms.TextBox();
            this.dtp_DataHoraEntrada = new System.Windows.Forms.DateTimePicker();
            this.btn_CadastrarVeiculo = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.dgv_Tabela = new System.Windows.Forms.DataGridView();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataENtrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataSaida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Carregar = new System.Windows.Forms.Button();
            this.btn_InformarSaida = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tabela)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Placa
            // 
            this.lbl_Placa.AutoSize = true;
            this.lbl_Placa.Location = new System.Drawing.Point(9, 29);
            this.lbl_Placa.Name = "lbl_Placa";
            this.lbl_Placa.Size = new System.Drawing.Size(34, 13);
            this.lbl_Placa.TabIndex = 0;
            this.lbl_Placa.Text = "Placa";
            // 
            // lbl_DataHoraEntrada
            // 
            this.lbl_DataHoraEntrada.AutoSize = true;
            this.lbl_DataHoraEntrada.Location = new System.Drawing.Point(9, 65);
            this.lbl_DataHoraEntrada.Name = "lbl_DataHoraEntrada";
            this.lbl_DataHoraEntrada.Size = new System.Drawing.Size(98, 13);
            this.lbl_DataHoraEntrada.TabIndex = 1;
            this.lbl_DataHoraEntrada.Text = "Data/Hora Entrada";
            // 
            // tb_Placa
            // 
            this.tb_Placa.Location = new System.Drawing.Point(113, 26);
            this.tb_Placa.Name = "tb_Placa";
            this.tb_Placa.Size = new System.Drawing.Size(214, 20);
            this.tb_Placa.TabIndex = 3;
            // 
            // dtp_DataHoraEntrada
            // 
            this.dtp_DataHoraEntrada.Location = new System.Drawing.Point(113, 59);
            this.dtp_DataHoraEntrada.Name = "dtp_DataHoraEntrada";
            this.dtp_DataHoraEntrada.Size = new System.Drawing.Size(214, 20);
            this.dtp_DataHoraEntrada.TabIndex = 4;
            // 
            // btn_CadastrarVeiculo
            // 
            this.btn_CadastrarVeiculo.Enabled = false;
            this.btn_CadastrarVeiculo.Location = new System.Drawing.Point(12, 168);
            this.btn_CadastrarVeiculo.Name = "btn_CadastrarVeiculo";
            this.btn_CadastrarVeiculo.Size = new System.Drawing.Size(133, 52);
            this.btn_CadastrarVeiculo.TabIndex = 5;
            this.btn_CadastrarVeiculo.Text = "Cadastrar Veículo";
            this.btn_CadastrarVeiculo.UseVisualStyleBackColor = true;
            this.btn_CadastrarVeiculo.Click += new System.EventHandler(this.btn_CadastrarVeiculo_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Enabled = false;
            this.btn_Limpar.Location = new System.Drawing.Point(12, 226);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(133, 52);
            this.btn_Limpar.TabIndex = 6;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // dgv_Tabela
            // 
            this.dgv_Tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Tabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Placa,
            this.DataENtrada,
            this.DataSaida,
            this.Valor});
            this.dgv_Tabela.Enabled = false;
            this.dgv_Tabela.Location = new System.Drawing.Point(418, 3);
            this.dgv_Tabela.Name = "dgv_Tabela";
            this.dgv_Tabela.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_Tabela.Size = new System.Drawing.Size(444, 232);
            this.dgv_Tabela.TabIndex = 7;
            // 
            // Placa
            // 
            this.Placa.HeaderText = "Placa";
            this.Placa.Name = "Placa";
            this.Placa.Width = 70;
            // 
            // DataENtrada
            // 
            this.DataENtrada.HeaderText = "Data/Hora Entrada";
            this.DataENtrada.Name = "DataENtrada";
            this.DataENtrada.Width = 130;
            // 
            // DataSaida
            // 
            this.DataSaida.HeaderText = "Data/Hora Saída ";
            this.DataSaida.Name = "DataSaida";
            this.DataSaida.Width = 130;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.Width = 70;
            // 
            // btn_Carregar
            // 
            this.btn_Carregar.Location = new System.Drawing.Point(153, 226);
            this.btn_Carregar.Name = "btn_Carregar";
            this.btn_Carregar.Size = new System.Drawing.Size(131, 52);
            this.btn_Carregar.TabIndex = 8;
            this.btn_Carregar.Text = "Carregar LIstas";
            this.btn_Carregar.UseVisualStyleBackColor = true;
            this.btn_Carregar.Click += new System.EventHandler(this.btn_Carregar_Click);
            // 
            // btn_InformarSaida
            // 
            this.btn_InformarSaida.Enabled = false;
            this.btn_InformarSaida.Location = new System.Drawing.Point(151, 168);
            this.btn_InformarSaida.Name = "btn_InformarSaida";
            this.btn_InformarSaida.Size = new System.Drawing.Size(133, 52);
            this.btn_InformarSaida.TabIndex = 9;
            this.btn_InformarSaida.Text = "Informar Saída";
            this.btn_InformarSaida.UseVisualStyleBackColor = true;
            this.btn_InformarSaida.Click += new System.EventHandler(this.btn_InformarSaida_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(874, 401);
            this.Controls.Add(this.btn_InformarSaida);
            this.Controls.Add(this.btn_Carregar);
            this.Controls.Add(this.dgv_Tabela);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_CadastrarVeiculo);
            this.Controls.Add(this.dtp_DataHoraEntrada);
            this.Controls.Add(this.tb_Placa);
            this.Controls.Add(this.lbl_DataHoraEntrada);
            this.Controls.Add(this.lbl_Placa);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Garagem Atos";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Placa;
        private System.Windows.Forms.Label lbl_DataHoraEntrada;
        private System.Windows.Forms.TextBox tb_Placa;
        private System.Windows.Forms.DateTimePicker dtp_DataHoraEntrada;
        private System.Windows.Forms.Button btn_CadastrarVeiculo;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.DataGridView dgv_Tabela;
        private System.Windows.Forms.Button btn_Carregar;
        private System.Windows.Forms.Button btn_InformarSaida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataENtrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataSaida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
    }
}

