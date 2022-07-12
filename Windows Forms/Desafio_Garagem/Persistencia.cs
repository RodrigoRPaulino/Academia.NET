using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Desafio_Garagem
{
    internal class Persistencia
    {
        /// <summary>
        /// Método para ler arquivos de entrada
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="caminho"></param>
        /// <param name="dgv_Tabela"></param>

        public static void lerArquivoEntrada(List<Veiculo> lista, string caminho, DataGridView dgv_Tabela)
        {
           
            StreamReader leitorEntrada = new StreamReader(caminho);
            string linha;
            string[] strLista;
            lista.Clear();
            //enquanto o leitor de entrada for diferente do final da leitura 
            while (!leitorEntrada.EndOfStream)
            {   
                linha = leitorEntrada.ReadLine();
                strLista = linha.Split(';');
                //após splitar a lista, adicionamos a placa[0] e a hora da entrada[1]
                lista.Add(new Veiculo(strLista[0], DateTime.Parse(strLista[1])));
                // adicionando no data grid view
                dgv_Tabela.Rows.Add(strLista[0].ToUpper(), strLista[1]);

            }
        }
        /// <summary>
        /// método para ler os arquivos de saída
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="caminho"></param>
        /// <param name="dgv_Tabela"></param>
        public static void lerArquivoSaida(List<Veiculo> lista, string caminho, DataGridView dgv_Tabela)
        {
            StreamReader leitorSaida = new StreamReader(caminho);
            string linhaSaida;
            string[] strListaSaida;
            lista.Clear();
            while (!leitorSaida.EndOfStream)
            {
                linhaSaida = leitorSaida.ReadLine();
                strListaSaida = linhaSaida.Split(';');

                lista.Add(new Veiculo(strListaSaida[0], DateTime.Parse(strListaSaida[1]), DateTime.Parse(strListaSaida[2]),
                    int.Parse(strListaSaida[3]), double.Parse(strListaSaida[4])));

                dgv_Tabela.Rows.Add(strListaSaida[0].ToUpper(), strListaSaida[1], strListaSaida[2], strListaSaida[4]);

            }
        }
        /// <summary>
        /// gravando os arquivos de entrada 
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="caminho"></param>
        public static void gravarArquivoEntrada(List<Veiculo> lista, string caminho)
        {
            StreamWriter escritorEntrada = new StreamWriter(caminho);
            
            foreach (Veiculo veiculo in lista)
            {
                escritorEntrada.WriteLine(veiculo.Placa + ";" + veiculo.DataEntrada);
                escritorEntrada.Flush();
            }
            escritorEntrada.Close();
        }
        /// <summary>
        /// gravando os arquivos de saída
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="caminho"></param>
        public static void gravarArquivoSaida(List<Veiculo> lista, string caminho)
        {
            StreamWriter escritorSaida = new StreamWriter(caminho);

            foreach (Veiculo veiculo in lista)
            {
                escritorSaida.WriteLine(veiculo.Placa + ";" + veiculo.DataEntrada + ";" + veiculo.DataSaida + ";" + veiculo.TempoPermanencia + ";" + veiculo.ValorCobrado); 
                escritorSaida.Flush();
            }
            escritorSaida.Close();
        }
    }
}
