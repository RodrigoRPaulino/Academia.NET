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


namespace Trabalho_Garagem
{
    internal class Veiculo
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public DateTime DataEntrada { get; set; }
       
        public DateTime? DataSaida { get; set; }
        public decimal? ValorHora { get; set; }



        public Veiculo(string placa)
        {
            this.Placa = placa;
            this.DataEntrada = DateTime.Now;
            this.ValorHora = 0;

        }
        public Veiculo(string placa, DateTime dataEntrada)
        {
            Placa = placa;
            DataEntrada = dataEntrada;
            

        }
        public Veiculo( int id ,string placa, DateTime dataEntrada, DateTime? dataSaida)
        {
            Id = id;
            Placa = placa;
            DataEntrada = dataEntrada;
            DataSaida = dataSaida;
           
        }
        public Veiculo(string placa, DateTime dataEntrada,DateTime? dataSaida, decimal? valorHora) : this(placa)
        {
            DataEntrada = dataEntrada;
            DataSaida = dataSaida;
            ValorHora = valorHora;
        }
    }



}
