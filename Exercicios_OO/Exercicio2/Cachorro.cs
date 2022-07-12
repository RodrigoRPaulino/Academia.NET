using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//#2
//Crie um programa em C# no qual o usuário deverá informar o nome e o tipo de cinco animais de estimação. 
//O programa deverá exibir na tela para o usuário quantos Cachorros, Gatos e Peixes foram informados.

//Regras que deverão ser seguidas para a implementação do programa:

//Os únicos tipos de animais válidos são Cachorro, Gato, Peixe.
//Caso seja informado um tipo diferente o programa repetir até o usuário digitar um tipo válido.
//É obrigatório criar uma classe para representar o Animal.
//A classe deverá possuir dois dados privados (propriedades) para representar as características do animal.
//A classe deverá possuir métodos de acesso (propriedade getter e setter)
//para permitir que o usuário armazene/leia os dados dos dois dados privados (propriedades).

namespace Exercicio2
{
    internal class Cachorro
    {
        private string Nome { get; set; }
       private string Raca { get; set; }

        // construtor 
        public Cachorro()
        {

        }
        // método para inserir o cachorro

        // ctrl +k+d justifica o código
        public static Cachorro InserirCachorro()
        {
            Cachorro cachorro = new Cachorro();
            Console.WriteLine("Digite o nome do cachorro: ");
            cachorro.Nome = Console.ReadLine();
            Console.WriteLine("Digite a raça do cachorro: ");
            cachorro.Raca = Console.ReadLine();
            return cachorro;
        }
        public static void ListarCachorros(List<Cachorro> totalCachorros)
        {
            Console.WriteLine($"Temos um total de {totalCachorros.Count()} cachorros.");
            foreach (Cachorro cachorro in totalCachorros)
            {
                Console.WriteLine($"Nome: {cachorro.Nome} ; Raça: {cachorro.Raca}");
                Console.WriteLine($"_______________________________________________");
            }

        }
    }
}
