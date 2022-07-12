namespace CadastroAutomoveis
{
    partial class frmAutomovel
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
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.tbmodeloCarro = new System.Windows.Forms.TextBox();
            this.lblModeloCarro = new System.Windows.Forms.Label();
            this.lblFabricante = new System.Windows.Forms.Label();
            this.tbFabricante = new System.Windows.Forms.TextBox();
            this.lbOpcionais = new System.Windows.Forms.CheckedListBox();
            this.lblOpcionais = new System.Windows.Forms.Label();
            this.cbPortas = new System.Windows.Forms.ComboBox();
            this.lblPortas = new System.Windows.Forms.Label();
            this.dgAutomoveis = new System.Windows.Forms.DataGridView();
            this.modeloCarro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ac = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DH = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ABS = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.VE = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AB = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Portas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAutomoveis)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(48, 254);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(113, 50);
            this.btnsalvar.TabIndex = 0;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(220, 254);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(113, 50);
            this.btnlimpar.TabIndex = 1;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // tbmodeloCarro
            // 
            this.tbmodeloCarro.Location = new System.Drawing.Point(138, 19);
            this.tbmodeloCarro.Name = "tbmodeloCarro";
            this.tbmodeloCarro.Size = new System.Drawing.Size(210, 20);
            this.tbmodeloCarro.TabIndex = 2;
            // 
            // lblModeloCarro
            // 
            this.lblModeloCarro.AutoSize = true;
            this.lblModeloCarro.Location = new System.Drawing.Point(12, 22);
            this.lblModeloCarro.Name = "lblModeloCarro";
            this.lblModeloCarro.Size = new System.Drawing.Size(87, 13);
            this.lblModeloCarro.TabIndex = 3;
            this.lblModeloCarro.Text = "Modelo do carro:";
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.Location = new System.Drawing.Point(12, 52);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(102, 13);
            this.lblFabricante.TabIndex = 4;
            this.lblFabricante.Text = "Fabricante do carro:";
            // 
            // tbFabricante
            // 
            this.tbFabricante.Location = new System.Drawing.Point(138, 49);
            this.tbFabricante.Name = "tbFabricante";
            this.tbFabricante.Size = new System.Drawing.Size(210, 20);
            this.tbFabricante.TabIndex = 5;
            // 
            // lbOpcionais
            // 
            this.lbOpcionais.FormattingEnabled = true;
            this.lbOpcionais.Items.AddRange(new object[] {
            "Ar condicionado",
            "Direção hidráulica",
            "Freios ABS",
            "Air bag",
            "Vidros elétricos"});
            this.lbOpcionais.Location = new System.Drawing.Point(138, 94);
            this.lbOpcionais.Name = "lbOpcionais";
            this.lbOpcionais.Size = new System.Drawing.Size(220, 79);
            this.lbOpcionais.TabIndex = 6;
            // 
            // lblOpcionais
            // 
            this.lblOpcionais.AutoSize = true;
            this.lblOpcionais.Location = new System.Drawing.Point(12, 94);
            this.lblOpcionais.Name = "lblOpcionais";
            this.lblOpcionais.Size = new System.Drawing.Size(54, 13);
            this.lblOpcionais.TabIndex = 7;
            this.lblOpcionais.Text = "Opcionais";
            // 
            // cbPortas
            // 
            this.cbPortas.FormattingEnabled = true;
            this.cbPortas.Items.AddRange(new object[] {
            "2 portas",
            "3 portas",
            "4 portas",
            "5 portas"});
            this.cbPortas.Location = new System.Drawing.Point(138, 195);
            this.cbPortas.Name = "cbPortas";
            this.cbPortas.Size = new System.Drawing.Size(210, 21);
            this.cbPortas.TabIndex = 8;
            // 
            // lblPortas
            // 
            this.lblPortas.AutoSize = true;
            this.lblPortas.Location = new System.Drawing.Point(12, 203);
            this.lblPortas.Name = "lblPortas";
            this.lblPortas.Size = new System.Drawing.Size(56, 13);
            this.lblPortas.TabIndex = 9;
            this.lblPortas.Text = "Qtd portas";
            // 
            // dgAutomoveis
            // 
            this.dgAutomoveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAutomoveis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modeloCarro,
            this.fabricante,
            this.ac,
            this.DH,
            this.ABS,
            this.VE,
            this.AB,
            this.Portas});
            this.dgAutomoveis.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgAutomoveis.Enabled = false;
            this.dgAutomoveis.Location = new System.Drawing.Point(364, 12);
            this.dgAutomoveis.Name = "dgAutomoveis";
            this.dgAutomoveis.Size = new System.Drawing.Size(714, 354);
            this.dgAutomoveis.TabIndex = 10;
            // 
            // modeloCarro
            // 
            this.modeloCarro.HeaderText = "Modelo";
            this.modeloCarro.Name = "modeloCarro";
            this.modeloCarro.Width = 50;
            // 
            // fabricante
            // 
            this.fabricante.HeaderText = "Fabricante";
            this.fabricante.Name = "fabricante";
            this.fabricante.Width = 70;
            // 
            // ac
            // 
            this.ac.HeaderText = "AC";
            this.ac.Name = "ac";
            this.ac.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ac.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ac.Width = 25;
            // 
            // DH
            // 
            this.DH.HeaderText = "DH";
            this.DH.Name = "DH";
            // 
            // ABS
            // 
            this.ABS.HeaderText = "ABS";
            this.ABS.Name = "ABS";
            // 
            // VE
            // 
            this.VE.HeaderText = "VE";
            this.VE.Name = "VE";
            // 
            // AB
            // 
            this.AB.HeaderText = "AB";
            this.AB.Name = "AB";
            this.AB.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Portas
            // 
            this.Portas.HeaderText = "portas";
            this.Portas.Name = "Portas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Carregar da lista";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAutomovel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 389);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgAutomoveis);
            this.Controls.Add(this.lblPortas);
            this.Controls.Add(this.cbPortas);
            this.Controls.Add(this.lblOpcionais);
            this.Controls.Add(this.lbOpcionais);
            this.Controls.Add(this.tbFabricante);
            this.Controls.Add(this.lblFabricante);
            this.Controls.Add(this.lblModeloCarro);
            this.Controls.Add(this.tbmodeloCarro);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnsalvar);
            this.Name = "frmAutomovel";
            this.Text = "Cadastrando automóvel";
            this.Load += new System.EventHandler(this.frmAutomovel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAutomoveis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.TextBox tbmodeloCarro;
        private System.Windows.Forms.Label lblModeloCarro;
        private System.Windows.Forms.Label lblFabricante;
        private System.Windows.Forms.TextBox tbFabricante;
        private System.Windows.Forms.CheckedListBox lbOpcionais;
        private System.Windows.Forms.Label lblOpcionais;
        private System.Windows.Forms.ComboBox cbPortas;
        private System.Windows.Forms.Label lblPortas;
        private System.Windows.Forms.DataGridView dgAutomoveis;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloCarro;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabricante;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ac;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DH;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ABS;
        private System.Windows.Forms.DataGridViewCheckBoxColumn VE;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Portas;
        private System.Windows.Forms.Button button1;
    }
}