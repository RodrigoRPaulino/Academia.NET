using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SimplesWindowsFormsBanco;

namespace SimpleswindowsFormsBanco
{    /// <summary>
/// primeiro crio a classe Pessoa com suas variáveis
/// </summary>
    internal class Pessoa
    {
        public string Nome;
        public int Idade;
        public string Cpf;
        public string Endereco;
        public string Bairro;
        public string Cep;
        public string Cidade;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="idade"></param>
        /// <param name="cpf"></param>
        /// <param name="endereco"></param>
        /// <param name="bairro"></param>
        /// <param name="cidade"></param>
        public Pessoa(string nome, int idade, string cpf, string endereco, string cep, string bairro, string cidade)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Cpf = cpf;
            this.Endereco = endereco;
            this.Bairro = bairro;
            this.Cep = cep;
            this.Cidade = cidade;
        }
        public bool gravarPessoa()
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into pessoa values (@nome, @idade, @cpf, @ende, @bairro, @cep, @cidade);";
            command.Parameters.Add("@nome", SqlDbType.VarChar);
            command.Parameters.Add("@idade", SqlDbType.Int);
            command.Parameters.Add("@cpf", SqlDbType.VarChar);
            command.Parameters.Add("@ende", SqlDbType.VarChar);
            command.Parameters.Add("@bairro", SqlDbType.VarChar);
            command.Parameters.Add("@cep", SqlDbType.VarChar);
            command.Parameters.Add("@cidade", SqlDbType.VarChar);
            command.Parameters[0].Value = Nome;
            command.Parameters[1].Value = Idade;
            command.Parameters[2].Value = Cpf;
            command.Parameters[3].Value = Endereco;
            command.Parameters[4].Value = Bairro;
            command.Parameters[5].Value = Cep;
            command.Parameters[6].Value = Cidade;
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
