namespace GEstaoDeMedidasGlicemicas
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
            this.btn_Conectar = new System.Windows.Forms.Button();
            this.listView_medidasGlicemias = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_Medida = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Medida = new System.Windows.Forms.TextBox();
            this.tb_ValorGlicemico = new System.Windows.Forms.TextBox();
            this.tb_DataMedicao = new System.Windows.Forms.TextBox();
            this.tb_Paciente = new System.Windows.Forms.TextBox();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.btn_Remover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Conectar
            // 
            this.btn_Conectar.Location = new System.Drawing.Point(251, 299);
            this.btn_Conectar.Name = "btn_Conectar";
            this.btn_Conectar.Size = new System.Drawing.Size(116, 23);
            this.btn_Conectar.TabIndex = 1;
            this.btn_Conectar.Text = "Conectar";
            this.btn_Conectar.UseVisualStyleBackColor = true;
            this.btn_Conectar.Click += new System.EventHandler(this.btn_Conectar_Click);
            // 
            // listView_medidasGlicemias
            // 
            this.listView_medidasGlicemias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView_medidasGlicemias.HideSelection = false;
            this.listView_medidasGlicemias.Location = new System.Drawing.Point(2, 1);
            this.listView_medidasGlicemias.Name = "listView_medidasGlicemias";
            this.listView_medidasGlicemias.Size = new System.Drawing.Size(365, 279);
            this.listView_medidasGlicemias.TabIndex = 2;
            this.listView_medidasGlicemias.UseCompatibleStateImageBehavior = false;
            this.listView_medidasGlicemias.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID Medida";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Valor Glicêmico";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Data Medição";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Paciente";
            this.columnHeader4.Width = 100;
            // 
            // lbl_Medida
            // 
            this.lbl_Medida.AutoSize = true;
            this.lbl_Medida.Location = new System.Drawing.Point(12, 302);
            this.lbl_Medida.Name = "lbl_Medida";
            this.lbl_Medida.Size = new System.Drawing.Size(56, 13);
            this.lbl_Medida.TabIndex = 3;
            this.lbl_Medida.Text = "ID Medida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor Glicêmico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data Medição";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-1, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Paciente";
            // 
            // tb_Medida
            // 
            this.tb_Medida.Location = new System.Drawing.Point(106, 302);
            this.tb_Medida.Name = "tb_Medida";
            this.tb_Medida.Size = new System.Drawing.Size(100, 20);
            this.tb_Medida.TabIndex = 7;
            // 
            // tb_ValorGlicemico
            // 
            this.tb_ValorGlicemico.Location = new System.Drawing.Point(108, 328);
            this.tb_ValorGlicemico.Name = "tb_ValorGlicemico";
            this.tb_ValorGlicemico.Size = new System.Drawing.Size(100, 20);
            this.tb_ValorGlicemico.TabIndex = 8;
            // 
            // tb_DataMedicao
            // 
            this.tb_DataMedicao.Location = new System.Drawing.Point(108, 354);
            this.tb_DataMedicao.Name = "tb_DataMedicao";
            this.tb_DataMedicao.Size = new System.Drawing.Size(100, 20);
            this.tb_DataMedicao.TabIndex = 9;
            // 
            // tb_Paciente
            // 
            this.tb_Paciente.Location = new System.Drawing.Point(108, 380);
            this.tb_Paciente.Name = "tb_Paciente";
            this.tb_Paciente.Size = new System.Drawing.Size(100, 20);
            this.tb_Paciente.TabIndex = 10;
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.Location = new System.Drawing.Point(251, 360);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(116, 23);
            this.btn_Adicionar.TabIndex = 11;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = true;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // btn_Remover
            // 
            this.btn_Remover.Location = new System.Drawing.Point(251, 413);
            this.btn_Remover.Name = "btn_Remover";
            this.btn_Remover.Size = new System.Drawing.Size(116, 23);
            this.btn_Remover.TabIndex = 12;
            this.btn_Remover.Text = "Remover";
            this.btn_Remover.UseVisualStyleBackColor = true;
            this.btn_Remover.Click += new System.EventHandler(this.btn_Remover_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Remover);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.tb_Paciente);
            this.Controls.Add(this.tb_DataMedicao);
            this.Controls.Add(this.tb_ValorGlicemico);
            this.Controls.Add(this.tb_Medida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Medida);
            this.Controls.Add(this.listView_medidasGlicemias);
            this.Controls.Add(this.btn_Conectar);
            this.Name = "Form1";
            this.Text = "Gerenciador de medidas glicemicas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Conectar;
        private System.Windows.Forms.ListView listView_medidasGlicemias;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lbl_Medida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Medida;
        private System.Windows.Forms.TextBox tb_ValorGlicemico;
        private System.Windows.Forms.TextBox tb_DataMedicao;
        private System.Windows.Forms.TextBox tb_Paciente;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.Button btn_Remover;
    }
}

