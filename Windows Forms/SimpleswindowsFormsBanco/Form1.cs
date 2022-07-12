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

namespace SimpleswindowsFormsBanco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// string nome = tb_Nome 
        /// int idade = tb_Idade
        /// string cpf = tb_Cpf
        /// string endereco = tb_Endereco
        /// string cep = tb_Cep
        /// string bairro = tb_ Bairro
        /// string cidade = tb_Cidade
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            // instaciando a classe ->Segunda parte sera criar o banco de dados.
            Pessoa p = new Pessoa(tb_Nome.Text, int.Parse(tb_Idade.Text), tb_Cpf.Text, tb_Endereco.Text, tb_Cep.Text, tb_Bairro.Text, tb_Cidade.Text);
            MessageBox.Show($"Nome: {p.Nome} ; Idade: {p.Idade} ; Cpf: {p.Cpf}\n" +
                            $"Endereço:{p.Endereco}\n" +
                            $"CEP: {p.Cep}; Bairro: {p.Bairro}; Cidade:{p.Cidade}");
            p.gravarPessoa(); 
        }

        private void btn_Remover_Click(object sender, EventArgs e)
        {

            
            

                //lembre que o remover está relacionado com ListView e a região
                //selecionada

                SqlConnection conexao = new SqlConnection(conexaoString);
                conexao.Open();
                try
                {
                    //MessageBox.Show(listView_medidasGlicemias.SelectedItems[0].Text);
                    int idMedidaGlicemia = int.Parse(listView_medidasGlicemia.SelectedItems[0].Text);

                    //gerar sentenças SQL
                    string sqlTexto = "DELETE FROM MedidaGlicemia WHERE idMedidaGlicemia = @idMedidaGlicemia";

                    SqlCommand comando = new SqlCommand(sqlTexto, conexao);
                    comando.Parameters.AddWithValue("@idMedidaGlicemia", idMedidaGlicemia);

                    //executar sentença SQL
                    if (comando.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("Removido com sucesso: " + listView_medidasGlicemia.SelectedItems[0].Text);
                    }
                }
                catch (Exception erro)
                {
                }


                conexao.Close();

                //recarregar ListView
                carregarListView();

            

        }
    }
}
