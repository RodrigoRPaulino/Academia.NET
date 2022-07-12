using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace GestaoVendas
{
    public partial class frmProdutos : Form
    {

        public frmProdutos()
        {
            InitializeComponent();
        }

        private void btn_InserirProduto_Click(object sender, EventArgs e)
        {
            Produtos produtos = new Produtos
           (int.Parse(tb_CodEAN.Text),tb_NomeProduto.Text.ToUpper(),int.Parse(tb_Estoque.Text),double.Parse(tb_ValorProduto.Text));
            produtos.GravarProdutos();
            dgv_Produtos.Rows.Add(int.Parse(tb_CodEAN.Text), tb_NomeProduto.Text.ToUpper(), int.Parse(tb_Estoque.Text), double.Parse(tb_ValorProduto.Text));
            MessageBox.Show("Produto cadastrado com sucesso!");

        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            frm_Home home = new frm_Home();
            home.ShowDialog();
            home.Focus();
            home.Close();
        }
    }
}
