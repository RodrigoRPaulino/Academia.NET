using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio_Garagem
{
    public partial class Form1 : Form
    {   // criação das listas de entrada e saida de veículos.     
        List<Veiculo> listaEntrada = new List<Veiculo>();
        List<Veiculo> listaSaida = new List<Veiculo>();
        /// <summary>
        /// variáveis com o endereço de entrada e saida onde serão populadas as listas
        /// de entrada e saida criando-as em arquivos.
        /// </summary>
        string caminhoEntrada = @"C:\Users\Rodrigo\source\repos\Academia.Net\Windows Forms\Desafio_Garagem\listaEntradas.dat";
        string caminhoSaida = @"C:\Users\Rodrigo\source\repos\Academia.Net\Windows Forms\Desafio_Garagem\listaSaidas.dat";

        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// botao criado no windows forms para cadastrar os veículos informados pelo usuário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_CadastrarVeiculo_Click(object sender, EventArgs e)
        {   // aqui tratamos a placa inserida. Se o usuário deixar o campo da placa em branco ou
            // se a lista de entradas for maior que 50 (vagas) a lista não sera mais populada
            
            if (tb_Placa.Text.Equals("") || listaEntrada.Count > 50)
            {
                //passando uma mensagem ao usuário.
                MessageBox.Show("Para qualquer operação, é preciso informar a placa\nou a garagem está lotada", "Alerta");
                return;
            }
            // pegamos a placa inserida pelo usuário e a deixamos maiúscula
            tb_Placa.Text = tb_Placa.Text.ToUpper();
            
            // Se a classe veiculo no método veiculo existe contiver a placa  na lista de entradas
            // digitamos a mensagem ao usúario e o programa nao prossegue.
            if (Veiculo.VeiculoExiste(tb_Placa.Text, listaEntrada))
            {
                MessageBox.Show("Este Veiculo ja esta estacionado","Alerta");
            }
           
            else
            {   // senão o programa insere as informações da placa e a dataHora de entrada
                
                DateTime dataHora = DateTime.Now;   
                listaEntrada.Add(new Veiculo(tb_Placa.Text, dataHora));

                // gravamos o arquivo de entrada atualizando o arquivo
                Persistencia.gravarArquivoEntrada(listaEntrada, caminhoEntrada);

                //atualizamos o datagridview
                //limpamos as linhas da tabela
                dgv_Tabela.Rows.Clear();
                // lemos a lista de entrada, o arquivo de entrada e a tabela  
                Persistencia.lerArquivoEntrada(listaEntrada, caminhoEntrada, dgv_Tabela);
                // lemos a lista de saída, o arquivo de saída e a tabela
                Persistencia.lerArquivoSaida(listaSaida, caminhoSaida, dgv_Tabela);

                MessageBox.Show("Operação de entrada OK", "Alerta");
            }
            // limpamos o textBox da placa 
            tb_Placa.Text = "";
        }

        private void btn_InformarSaida_Click(object sender, EventArgs e)
        {
            // se a placa for igual a vazio ou a lista de entradas for igual a 0,
            // informamos ao usuário que a garagem está vazia.
            if (tb_Placa.Text.Equals("") || listaEntrada.Count == 0)
            {
                MessageBox.Show("Para qualquer operação, é preciso informar a placa\ne o veículo precisa estar na garagem","Alerta");
                return;
            }
            tb_Placa.Text = tb_Placa.Text.ToUpper();

            // Se a classe veiculo no método veiculo existe contiver a placa  na lista de entradas
            // o programa adiciona essas informações para tratarmos a saida.
            if (Veiculo.VeiculoExiste(tb_Placa.Text, listaEntrada))
            {
                //criamos a variavel posicao pegando a classe Veiculo no método
                // com os dados da placa na lista de entradas para gerar a saída do veiculo.
                int posicao = Veiculo.PosicaoVeiculo(tb_Placa.Text, listaEntrada);
                Veiculo temporarioSaida = listaEntrada[posicao];
                temporarioSaida.DataSaida = DateTime.Now;

                //horaEntrada = "8:14"; -> 8*60+14 = 494
                //horaSaida = "10:15";  -> 10*60+15 = 615
                //descobrindo o tempo em minutos da entrada
                // vetor para splitar a data de entrada para pegarmos a hora da saída
                string[] vetorDados = temporarioSaida.DataEntrada.ToString().Split(' ');

                vetorDados = vetorDados[1].Split(':');

                int hora = int.Parse(vetorDados[0]);
                int minutos = int.Parse(vetorDados[1]);
                int entrada = hora * 60 + minutos;

                //descobrindo o tempo em minutos da saida
                vetorDados = temporarioSaida.DataSaida.ToString().Split(' ');
                
                //vetor para splitar a hora dos minutos
                vetorDados = vetorDados[1].Split(':');
                hora = int.Parse(vetorDados[0]);
                minutos = int.Parse(vetorDados[1]);
               
                int saida = hora * 60 + minutos;

                //calculo de permanência na garagem
                temporarioSaida.TempoPermanencia = saida - entrada;
                double resultado = (double)temporarioSaida.TempoPermanencia / 60;
                // * A função Math.ceilling Retorna o menor valor inteiro maior ou igual ao número especificado.
                double qtdHorasNaGaragem = Math.Ceiling(resultado);

                temporarioSaida.ValorCobrado = (int)qtdHorasNaGaragem * 5;
                
                temporarioSaida.TempoPermanencia = 1; 
                temporarioSaida.ValorCobrado = temporarioSaida.TempoPermanencia * 5;

                //adiciona o veiculo na lista de saida
                listaSaida.Add(temporarioSaida);
                //atualizar o arquivo de saida
                Persistencia.gravarArquivoSaida(listaSaida, caminhoSaida);

                //retira o veiculo da lista de entrada
                listaEntrada.RemoveAt(posicao);
                //atualizar o arquivo de entrada
                Persistencia.gravarArquivoEntrada(listaEntrada, caminhoEntrada);

                //atualizar o datagrid
                dgv_Tabela.Rows.Clear();
                Persistencia.lerArquivoEntrada(listaEntrada, caminhoEntrada, dgv_Tabela);
                Persistencia.lerArquivoSaida(listaSaida, caminhoSaida, dgv_Tabela);

                MessageBox.Show("Operação de saída OK","Alerta");
            } else
            {
                MessageBox.Show("Veículo não localizado no pátido", "Alerta");
            }
            tb_Placa.Text = "";
        }

        private void btn_Carregar_Click(object sender, EventArgs e)
        {
            // exibe os veículos que estão na garagem e que sairam da garagem.
            Persistencia.lerArquivoEntrada(listaEntrada, caminhoEntrada, dgv_Tabela);
            Persistencia.lerArquivoSaida(listaSaida, caminhoSaida, dgv_Tabela);

            //so habilita os botoes após clicar no botão carregar
            btn_CadastrarVeiculo.Enabled = true;
            btn_InformarSaida.Enabled = true;
            btn_Limpar.Enabled = true;
            btn_Carregar.Enabled = false;
        }
        /// <summary>
        /// limpa o formulário e desabilita o botão carregar listas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            tb_Placa.Clear();
            dgv_Tabela.Rows.Clear();
            listaEntrada.Clear();
            listaSaida.Clear();
            btn_Carregar.Enabled = true;
            btn_CadastrarVeiculo.Enabled = false;
            btn_InformarSaida.Enabled = false;
            btn_Limpar.Enabled = false;
        }
    }
}









