using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Gato
    {
        public string Nome { get; set; }
        public string Raca { get; set; }

        public Gato()
        {

        }

        public static Gato InserirGato()
        {
            Gato gato = new Gato();
            Console.WriteLine("Digite o nome do gato: ");
            gato.Nome = Console.ReadLine();
            Console.WriteLine("Digite a raça do gato: ");
            gato.Raca = Console.ReadLine();
            return gato;
        }
       



        public static void ListarGatos(List<Gato> totalGatos)
        {
            Console.WriteLine($"Temos um total de : {totalGatos.Count()} gatos.");
            foreach(Gato gatos in totalGatos)
            {
                Console.WriteLine($"Nome: {gatos.Nome} ; Raça: {gatos.Raca}");
                Console.WriteLine("_________________________________________");
            }
        }
    }
}
