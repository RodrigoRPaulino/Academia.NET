using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Peixe
    {
        public string Nome { get; set; }
        public string Raca { get; set; }

        public Peixe()
        {

        }

        public static Peixe InserirPeixe()
        {
            Peixe peixe = new Peixe();
            Console.WriteLine("Digite o nome do peixe: ");
            peixe.Nome = Console.ReadLine();
            Console.WriteLine("Digite a raça do peixe: ");
            peixe.Raca = Console.ReadLine();
            return peixe;
        }

        public static void ListarPeixes(List<Peixe> totalPeixes)
        {
            Console.WriteLine($"Temos um total de {totalPeixes.Count()} peixes.");
            foreach(Peixe peixes in totalPeixes)
            {
                Console.WriteLine($"Nome: {peixes.Nome} ; Raça {peixes.Raca}");
                Console.WriteLine("___________________________________________");
            }
        }

       
    }


}
