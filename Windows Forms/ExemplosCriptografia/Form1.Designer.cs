namespace ExemplosCriptografia
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Frase = new System.Windows.Forms.TextBox();
            this.btn_CriptoAssimetrica = new System.Windows.Forms.Button();
            this.lbl_Cripto = new System.Windows.Forms.Label();
            this.btn_DescriptoAssimetrica = new System.Windows.Forms.Button();
            this.lbl_Descriptografar = new System.Windows.Forms.Label();
            this.btn_CriptoSimetrica = new System.Windows.Forms.Button();
            this.tb_Chave = new System.Windows.Forms.TextBox();
            this.lbl_Chave = new System.Windows.Forms.Label();
            this.btn_DescriptoSimetrico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Frase :";
            // 
            // tb_Frase
            // 
            this.tb_Frase.Location = new System.Drawing.Point(57, 25);
            this.tb_Frase.Name = "tb_Frase";
            this.tb_Frase.Size = new System.Drawing.Size(147, 20);
            this.tb_Frase.TabIndex = 1;
            // 
            // btn_CriptoAssimetrica
            // 
            this.btn_CriptoAssimetrica.Location = new System.Drawing.Point(2, 162);
            this.btn_CriptoAssimetrica.Name = "btn_CriptoAssimetrica";
            this.btn_CriptoAssimetrica.Size = new System.Drawing.Size(99, 23);
            this.btn_CriptoAssimetrica.TabIndex = 2;
            this.btn_CriptoAssimetrica.Text = "Cripto Assimetrica";
            this.btn_CriptoAssimetrica.UseVisualStyleBackColor = true;
            this.btn_CriptoAssimetrica.Click += new System.EventHandler(this.btn_Criptografia_Click);
            // 
            // lbl_Cripto
            // 
            this.lbl_Cripto.AutoSize = true;
            this.lbl_Cripto.Location = new System.Drawing.Point(12, 65);
            this.lbl_Cripto.Name = "lbl_Cripto";
            this.lbl_Cripto.Size = new System.Drawing.Size(102, 13);
            this.lbl_Cripto.TabIndex = 3;
            this.lbl_Cripto.Text = "Frase Criptografada:";
            // 
            // btn_DescriptoAssimetrica
            // 
            this.btn_DescriptoAssimetrica.Location = new System.Drawing.Point(107, 162);
            this.btn_DescriptoAssimetrica.Name = "btn_DescriptoAssimetrica";
            this.btn_DescriptoAssimetrica.Size = new System.Drawing.Size(117, 23);
            this.btn_DescriptoAssimetrica.TabIndex = 4;
            this.btn_DescriptoAssimetrica.Text = "Descripto Assimetrica";
            this.btn_DescriptoAssimetrica.UseVisualStyleBackColor = true;
            this.btn_DescriptoAssimetrica.Click += new System.EventHandler(this.btn_Descriptografar_Click);
            // 
            // lbl_Descriptografar
            // 
            this.lbl_Descriptografar.AutoSize = true;
            this.lbl_Descriptografar.Location = new System.Drawing.Point(9, 132);
            this.lbl_Descriptografar.Name = "lbl_Descriptografar";
            this.lbl_Descriptografar.Size = new System.Drawing.Size(120, 13);
            this.lbl_Descriptografar.TabIndex = 5;
            this.lbl_Descriptografar.Text = "Frase Descriptografada:";
            // 
            // btn_CriptoSimetrica
            // 
            this.btn_CriptoSimetrica.Location = new System.Drawing.Point(413, 162);
            this.btn_CriptoSimetrica.Name = "btn_CriptoSimetrica";
            this.btn_CriptoSimetrica.Size = new System.Drawing.Size(117, 23);
            this.btn_CriptoSimetrica.TabIndex = 6;
            this.btn_CriptoSimetrica.Text = "Cripto Simetrica";
            this.btn_CriptoSimetrica.UseVisualStyleBackColor = true;
            this.btn_CriptoSimetrica.Click += new System.EventHandler(this.btn_CriptoSimetrica_Click);
            // 
            // tb_Chave
            // 
            this.tb_Chave.Location = new System.Drawing.Point(391, 25);
            this.tb_Chave.Name = "tb_Chave";
            this.tb_Chave.Size = new System.Drawing.Size(169, 20);
            this.tb_Chave.TabIndex = 7;
            // 
            // lbl_Chave
            // 
            this.lbl_Chave.AutoSize = true;
            this.lbl_Chave.Location = new System.Drawing.Point(324, 25);
            this.lbl_Chave.Name = "lbl_Chave";
            this.lbl_Chave.Size = new System.Drawing.Size(41, 13);
            this.lbl_Chave.TabIndex = 8;
            this.lbl_Chave.Text = "Chave:";
            // 
            // btn_DescriptoSimetrico
            // 
            this.btn_DescriptoSimetrico.Location = new System.Drawing.Point(552, 162);
            this.btn_DescriptoSimetrico.Name = "btn_DescriptoSimetrico";
            this.btn_DescriptoSimetrico.Size = new System.Drawing.Size(117, 23);
            this.btn_DescriptoSimetrico.TabIndex = 9;
            this.btn_DescriptoSimetrico.Text = "Descripto Simetrico";
            this.btn_DescriptoSimetrico.UseVisualStyleBackColor = true;
            this.btn_DescriptoSimetrico.Click += new System.EventHandler(this.btn_DescriptoSimetrico_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 450);
            this.Controls.Add(this.btn_DescriptoSimetrico);
            this.Controls.Add(this.lbl_Chave);
            this.Controls.Add(this.tb_Chave);
            this.Controls.Add(this.btn_CriptoSimetrica);
            this.Controls.Add(this.lbl_Descriptografar);
            this.Controls.Add(this.btn_DescriptoAssimetrica);
            this.Controls.Add(this.lbl_Cripto);
            this.Controls.Add(this.btn_CriptoAssimetrica);
            this.Controls.Add(this.tb_Frase);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Frase;
        private System.Windows.Forms.Button btn_CriptoAssimetrica;
        private System.Windows.Forms.Label lbl_Cripto;
        private System.Windows.Forms.Button btn_DescriptoAssimetrica;
        private System.Windows.Forms.Label lbl_Descriptografar;
        private System.Windows.Forms.Button btn_CriptoSimetrica;
        private System.Windows.Forms.TextBox tb_Chave;
        private System.Windows.Forms.Label lbl_Chave;
        private System.Windows.Forms.Button btn_DescriptoSimetrico;
    }
}

