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
using Microsoft.Data.SqlClient;

namespace GEstaoDeMedidasGlicemicas
{
    public partial class Form1 : Form
    {
        private string conexaoString = ConfigurationManager.ConnectionStrings["GlicemiaDBString"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
            carregarListVew();

        }
        private void limparTextBox()
        {
            tb_Medida.Text = "";
            tb_DataMedicao.Text = "";
            tb_ValorGlicemico.Text = "";
            tb_Paciente.Text = "";
        }
       

        private void carregarListVew()
        {
            SqlConnection conexao = new SqlConnection(conexaoString);
            conexao.Open();
            string sqlTexto = "SELECT idMedidaGlicemia, valorGlicemia, dataMedida, idPaciente FROM MedidaGlicemia";
            SqlCommand comando = new SqlCommand(sqlTexto, conexao);

            listView_medidasGlicemias.Items.Clear();
            SqlDataReader leitor = comando.ExecuteReader();
            int i = 0;
            while (leitor.Read())
            {
                listView_medidasGlicemias.Items.Add(leitor["idMedidaGlicemia"].ToString());
                listView_medidasGlicemias.Items[i].SubItems.Add(leitor["valorGlicemia"].ToString());
                listView_medidasGlicemias.Items[i].SubItems.Add(leitor["dataMedida"].ToString());
                listView_medidasGlicemias.Items[i].SubItems.Add(leitor["idPaciente"].ToString());
                i++;
            }

            conexao.Close();

        }


        private void btn_Conectar_Click(object sender, EventArgs e)
        {
            carregarListVew();
            
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(conexaoString);
            conexao.Open();
            try
            {
                //capturar valores das variáveis
                int idMedidaGlicemia = int.Parse(tb_Medida.Text);
                int valorGlicemia = int.Parse(tb_ValorGlicemico.Text);
                string dataMedida = tb_DataMedicao.Text;
                int idPaciente = int.Parse(tb_Paciente.Text);

                //gerar sentenças SQL
                string sqlTexto = "INSERT INTO MedidaGlicemia (idMedidaGlicemia, valorGlicemia, dataMedida, idPaciente) VALUES(@idMedidaGlicemia, @valorGlicemia, @dataMedida, @idPaciente)";
                SqlCommand comando = new SqlCommand(sqlTexto, conexao);
                comando.Parameters.AddWithValue("@idMedidaGlicemia", idMedidaGlicemia);
                comando.Parameters.AddWithValue("@valorGlicemia", valorGlicemia);
                comando.Parameters.AddWithValue("@dataMedida", dataMedida);
                comando.Parameters.AddWithValue("@idPaciente", idPaciente);

                //executar sentença SQL
                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

            conexao.Close();

            //recarregar ListView
            
            limparTextBox();
            carregarListVew();
        }

        private void btn_Remover_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(conexaoString);
            conexao.Open();
            try
            {
                //MessageBox.Show(listView_medidasGlicemias.SelectedItems[0].Text);
                int idMedidaGlicemia = int.Parse(listView_medidasGlicemias.SelectedItems[0].Text);

                //gerar sentenças SQL
                string sqlTexto = "DELETE FROM MedidaGlicemia WHERE idMedidaGlicemia = @idMedidaGlicemia";

                SqlCommand comando = new SqlCommand(sqlTexto, conexao);
                comando.Parameters.AddWithValue("@idMedidaGlicemia", idMedidaGlicemia);

                //executar sentença SQL
                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Removido com sucesso!");
            }
            conexao.Close();
            carregarListVew();

            //recarregar ListView

        }
    }
}
