using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace GestaoVendas
{
    public partial class frmVendas : Form
    {
        public frmVendas()
        {
            InitializeComponent();
        }
        //public void CarregarDataGrid()
        //{
        //    Banco banco = new Banco();
        //    SqlConnection conexao = new SqlConnection(banco.stringConexao);
        //    conexao.Open();
        //    string sqlTexto = "SELECT id, id_Cliente, valorTotal FROM vendas";
        //    SqlCommand comando = new SqlCommand(sqlTexto, conexao);
        //    dgv_Vendas.Rows.Clear();
        //    SqlDataReader leitor = comando.ExecuteReader();
        //    int i = 0;
        //    while (leitor.Read())
        //    {
        //        dgv_Vendas.Rows.Add(leitor["id"].ToString());
        //        dgv_Vendas.Rows.Add(leitor["id_Cliente"].ToString());
        //        dgv_Vendas.Rows.Add(leitor["valorTotal"].ToString());
        //        i++;
        //    }
        //    conexao.Close();


        //}

        private void btn_RegistrarVenda_Click(object sender, EventArgs e)
        {
            Vendas vendas = new Vendas(int.Parse(tb_IdVenda.Text), int.Parse(tb_IdCliente.Text), double.Parse(tb_TotalVenda.Text));
            vendas.GravarVendas();
            dgv_Vendas.Rows.Add(int.Parse(tb_IdVenda.Text), int.Parse(tb_IdCliente.Text), double.Parse(tb_TotalVenda.Text));
            //CarregarDataGrid();

            MessageBox.Show("Venda Registrada!");

            // int idVenda, int idProduto,int codigoCliente, double valorUnidade, int quantidade, double valorTotal
        }
    }
}
