using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;




namespace GestaoVendas
{
    /// <summary>
    /// criando a classe de clientes 
    /// </summary>
    public class Clientes
    {
        
        public string Nome;
        public string Cpf;
        public string Telefone;
        public string Endereco;
        public string Cidade;
        public string Email;

        /// <summary>
        /// Construtor usado para tratar as informaçoes digitadas 
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="cpf"></param>
        /// <param name="telefone"></param>
        /// <param name="endereco"></param>
        /// <param name="cidade"></param>
        /// <param name="email"></param>
        public Clientes(string nome, string cpf, string telefone, string endereco, string cidade, string email)
        {
            
            this.Nome = nome;
            this.Cpf = cpf;
            this.Telefone = telefone;
            this.Endereco = endereco;
            this.Cidade = cidade;
            this.Email = email;
        }
        /// <summary>
        /// método para gravar clientes no banco de dados.
        /// </summary>
        /// <returns></returns>
        public bool GravarCliente()
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into clientes  values (@nome, @cpf, @telefone, @endereco, @cidade, @email);";                  
            command.Parameters.Add("@nome", SqlDbType.VarChar);
            command.Parameters.Add("@cpf", SqlDbType.VarChar);
            command.Parameters.Add("@telefone", SqlDbType.VarChar);
            command.Parameters.Add("@endereco", SqlDbType.VarChar);
            command.Parameters.Add("@cidade", SqlDbType.VarChar);
            command.Parameters.Add("@email", SqlDbType.VarChar);            
            command.Parameters[0].Value = Nome;
            command.Parameters[1].Value = Cpf;
            command.Parameters[2].Value = Telefone;
            command.Parameters[3].Value = Endereco;
            command.Parameters[4].Value = Cidade;
            command.Parameters[5].Value = Email;
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
