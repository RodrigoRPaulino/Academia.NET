using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace GestaoVendas
{
    internal class Produtos
    {

        public int CodEAN;
        public string NomeProduto;
        public int Estoque;
        public double ValorProduto;

        public Produtos(int codEAN, string nomeProduto, int estoque, double valorProduto)
        {
           
            CodEAN = codEAN;
            NomeProduto = nomeProduto;
            Estoque = estoque;
            ValorProduto = valorProduto;
        }

        public bool GravarProdutos()
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into produtos values (@codEAN, @nomeProduto, @estoque, @valorProduto);";
            //command.Parameters.Add("@idProduto", SqlDbType.Int);
            command.Parameters.Add("@codEAN", SqlDbType.VarChar);
            command.Parameters.Add("@nomeProduto", SqlDbType.VarChar);
            command.Parameters.Add("@estoque", SqlDbType.Int);
            command.Parameters.Add("@valorProduto", SqlDbType.Real);
            //command.Parameters[0].Value = IdProduto;
            command.Parameters[0].Value = CodEAN;
            command.Parameters[1].Value = NomeProduto;
            command.Parameters[2].Value = Estoque;
            command.Parameters[3].Value = ValorProduto;

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                banco.fecharConexao();
            }


        }
    }
}
