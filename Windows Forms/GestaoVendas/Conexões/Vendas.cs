using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace GestaoVendas
{
    internal class Vendas
    {

        public int Id;
        public int IdCliente;
        public double ValorTotal;

        public Vendas(int id, int idCliente, double valorTotal)
        {
            Id = id;
            IdCliente = idCliente;
            ValorTotal = valorTotal;

        }

        


        public bool GravarVendas()
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into vendas values (@id_Cliente, @valorTotal)";            
            command.Parameters.Add("@id_Cliente", SqlDbType.Int);
            command.Parameters.Add("@valorTotal", SqlDbType.Real);           
            command.Parameters[0].Value = IdCliente;
            command.Parameters[1].Value = ValorTotal;

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
