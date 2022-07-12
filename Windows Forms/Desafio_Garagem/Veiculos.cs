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

    class Veiculo
    {
        
        string placa;
        DateTime dataEntrada;
        DateTime dataSaida;
        int tempoPermanencia;
        double valorCobrado;
        /// <summary>
        /// construtor usando o parametro da placa.
        /// </summary>
        /// <param name="placa"></param>  
        public Veiculo(string placa)
        {
            this.Placa = placa;
        }
        /// <summary>
        /// construtor usado para tratar a lista de entradas de veículos.
        /// </summary>
        /// <param name="placa"></param>
        /// <param name="dataEntrada"></param>
        public Veiculo(string placa, DateTime dataEntrada) : this(placa)
        {
            this.DataEntrada = dataEntrada;
        }
        /// <summary>
        /// construtor usado para tratar a lista de saidas de veículos.
        /// </summary>
        /// <param name="placa"></param>
        /// <param name="dataEntrada"></param>
        /// <param name="dataSaida"></param>
        /// <param name="tempoPermanencia"></param>
        /// <param name="valorCobrado"></param>
        public Veiculo(string placa, DateTime dataEntrada, DateTime dataSaida, int tempoPermanencia, double valorCobrado) : this(placa)
        {
            this.DataEntrada = dataEntrada;
            this.DataSaida = dataSaida;
            this.TempoPermanencia = tempoPermanencia;
            this.ValorCobrado = valorCobrado;
        }

        public string Placa { get => placa; set => placa = value; }
        public DateTime DataEntrada { get => dataEntrada; set => dataEntrada = value; }
        public DateTime DataSaida { get => dataSaida; set => dataSaida = value; }
        public int TempoPermanencia { get => tempoPermanencia; set => tempoPermanencia = value; }
        public double ValorCobrado { get => valorCobrado; set => valorCobrado = value; }

        /// <summary>
        /// método para verificar se o veículo informado ja está na garagem.
        /// </summary>
        /// <param name="placa"></param>
        /// <param name="lista"></param>
        /// <returns></returns>
        public static bool VeiculoExiste(string placa, List<Veiculo> lista)
        {
            //percorrendo a lista.
            foreach (Veiculo v in lista)
            {  // se a placa do eículo for igual a placa da lista ele retorna um true.
                if (placa.Equals(v.Placa))
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// método para informar a posição do veículo na lista. 
        /// </summary>
        /// <param name="placa"></param>
        /// <param name="lista"></param>
        /// <returns></returns>
        public static int PosicaoVeiculo(string placa, List<Veiculo> lista)
        {   //usando a mesma lógica do método acima, aqui verificamos a posição do veiculo
            //na lista de entradas retornando um esc(-27).

            foreach (Veiculo v in lista)
            {
                if (placa.Equals(v.Placa))
                {
                    return lista.IndexOf(v);
                }
            }
            return -27;
        }
    }
}
