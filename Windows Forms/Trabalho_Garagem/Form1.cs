using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Trabalho_Garagem
{


    public partial class Form1 : Form
    {   //crio as listas de entrada e saida
        private string conexaoString = ConfigurationManager.ConnectionStrings["GaragemDB"].ConnectionString;

        List<Veiculo> listaSaidas = new List<Veiculo>();
        string caminho = @"C:\Users\Rodrigo\source\repos\Academia.Net\Windows Forms\Trabalho_Garagem\listaEntradas.dat";
        public Form1()
        {
            InitializeComponent();

        }

        private void btn_Carregar_Click(object sender, EventArgs e)
        {
            dgv_Tabela.Rows.Clear();
            List<Veiculo> listaEntradas = new List<Veiculo>();
            listaEntradas = ObterVeiculosEntrada();
            foreach (var item in listaEntradas)
            {
                var tempo = DateTime.Now.Subtract(item.DataEntrada).TotalMinutes;
                var valor = Math.Ceiling((tempo / 60)) * 5;
                dgv_Tabela.Rows.Add(item.Placa, item.DataEntrada.ToString(), item.DataSaida,tempo, valor);


            }
            //foreach (Veiculo veiculo in listaEntradas)
            //{
            //    dgv_Tabela.Rows.Add(veiculo.Placa, veiculo.DataEntrada);

            //}
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            tb_Placa.Text = "";
            dgv_Tabela.Rows.Clear();

        }

        private void btn_CadastrarVeiculo_Click(object sender, EventArgs e)
        {

            bool veiculoExiste = VeiculoExiste(tb_Placa.Text.ToUpper());
            List<Veiculo> listaSaidas = new List<Veiculo>();
            listaSaidas = ObterVeiculosEntrada();
            if (listaSaidas.Count >= 50)
            {
                MessageBox.Show("A garagem está cheia!");
            }

            else if (veiculoExiste)
            {
                MessageBox.Show("Esse veículo já foi cadastrado.");
            }
            else
            {
                //capturar valores das variáveis
                Veiculo veiculo = new Veiculo(tb_Placa.Text.ToUpper());
                bool cadastrou = CadastrarVeiculo(veiculo);
                if (cadastrou)
                {
                    MessageBox.Show("Veículo Cadastrado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao Cadastrar Veículo");
                }
            }



        }
        private bool CadastrarVeiculo(Veiculo veiculo)
        {
            SqlConnection conexao = new SqlConnection(conexaoString);
            conexao.Open();
            try
            {
                //gerar sentenças SQL
                string sqlTexto = "insert into Garagem (Placa, Entrada)values(@placa,@dataEntrada)";
                SqlCommand comando = new SqlCommand(sqlTexto, conexao);
                comando.Parameters.AddWithValue("@placa", veiculo.Placa);
                comando.Parameters.AddWithValue("@dataEntrada", veiculo.DataEntrada);

                //executar sentença SQL
                comando.ExecuteNonQuery();
                conexao.Close();
                return true;
            }
            catch (Exception erro)
            {
                conexao.Close();
                return false;
            }


        }
        private bool VeiculoExiste(string placa)
        {
            List<Veiculo> listaEntradas = new List<Veiculo>();
            SqlConnection conexao = new SqlConnection(conexaoString);
            conexao.Open();
            try
            {
                //gerar sentenças SQL
                string sqlTexto = "select * from Garagem where Placa = @placa and Saida is null";
                SqlCommand comando = new SqlCommand(sqlTexto, conexao);
                comando.Parameters.AddWithValue("@placa", placa);

                //executar sentença SQL
                //comando.ExecuteNonQuery();

                SqlDataReader leitor = comando.ExecuteReader();
                int i = 0;
                while (leitor.Read())
                {
                    DateTime? data;
                    if (leitor["Saida"].ToString() == "")
                    {
                        data = null;


                    }
                    else
                    {
                        data = DateTime.Parse(leitor["Entrada"].ToString());
                    }

                    listaEntradas.Add(new Veiculo(int.Parse(leitor["id"].ToString()), leitor["Placa"].ToString(), DateTime.Parse(leitor["Entrada"].ToString()), data));

                    i++;
                }

                conexao.Close();
                if (listaEntradas.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception erro)
            {
                conexao.Close();
                return false;
            }



        }

        private List<Veiculo> ObterVeiculosEntrada()
        {
            List<Veiculo> listaEntradas = new List<Veiculo>();
            SqlConnection conexao = new SqlConnection(conexaoString);
            conexao.Open();
            try
            {
                //gerar sentenças SQL
                string sqlTexto = "select * from Garagem where Saida is null";
                SqlCommand comando = new SqlCommand(sqlTexto, conexao);

                //executar sentença SQL
                //comando.ExecuteNonQuery();

                SqlDataReader leitor = comando.ExecuteReader();
                int i = 0;
                while (leitor.Read())
                {
                    DateTime? data;
                    if (leitor["Saida"].ToString() == "")
                    {
                        data = null;
                    }
                    else
                    {
                        data = DateTime.Parse(leitor["Entrada"].ToString());
                    }

                    listaEntradas.Add(new Veiculo(int.Parse(leitor["id"].ToString()), leitor["Placa"].ToString(), DateTime.Parse(leitor["Entrada"].ToString()), data));

                    i++;
                }

                conexao.Close();
                if (listaEntradas.Count > 0)
                {
                    return listaEntradas;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception erro)
            {
                conexao.Close();
                return null;
            }
        }
    }




}


