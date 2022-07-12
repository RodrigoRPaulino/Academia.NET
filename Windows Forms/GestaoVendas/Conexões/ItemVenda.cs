using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace GestaoVendas
{

    public class ItemVenda
    {

        public int Id;
        public int Id_Produto;
        public int Id_Vendas;
        public double ValorUnidade;
        public int Quantidade;
        public double ValorTotal;

        public ItemVenda(int id, int id_Produto,int id_Vendas, double valorUnidade, int quantidade, double valorTotal)
        {
           
            Id = id;
            Id_Produto = id_Produto;
            Id_Vendas = id_Vendas;
            ValorUnidade = valorUnidade;
            Quantidade = quantidade;
            ValorTotal = valorUnidade * quantidade;
        }
        public ItemVenda()
        {
           
        }


      

        public bool GravarItensVenda()
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into itemVenda values (@id_Produto,@id_Vendas, @valorUnidade, @quantidade, @valorTotal);";           
            command.Parameters.Add("@id_Produto", SqlDbType.Int);
            command.Parameters.Add("@id_Vendas", SqlDbType.Int);
            command.Parameters.Add("@valorUnidade", SqlDbType.Real);
            command.Parameters.Add("@quantidade", SqlDbType.Int);
            command.Parameters.Add("@valorTotal", SqlDbType.Real);
            command.Parameters[0].Value = Id_Produto;
            command.Parameters[1].Value = Id_Vendas;
            command.Parameters[2].Value = ValorUnidade;
            command.Parameters[3].Value = Quantidade;
            command.Parameters[4].Value = ValorTotal;
            
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
