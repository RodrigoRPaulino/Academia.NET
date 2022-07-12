/*Crie uma classe para representar um objeto em um Plano Cartesiano. Todo objeto no plano cartesiano
tem como atributos 'x' e 'y'. Dessa forma, crie os getters e setter de 'x' e 'y', o construtor básico e
um método para exibir um objeto (x, y).
Por fim, crie um programa em C# que cadastre 'n' objetos em uma lista (List), um método de que exiba
os objetos da lista.*/

namespace Exercicio6
{
    class Program
    {
        public static List<PlanoCartesiano> listaCoordenadas = new List<PlanoCartesiano>();

        public static void Main()
        {//o return devolve os dados para armazenar aqui
            PlanoCartesiano coordenadas = ColetarCoordenadas();
            //mostra os dados preenchidos das coordenadas
            MostrarCoordenadas(coordenadas);
                                      
        }
       
        public static PlanoCartesiano ColetarCoordenadas()
        {

            int posicaoX;
            int posicaoY;
            //Coletando dados do usuario
            Console.WriteLine();
            Console.WriteLine("Digite a coordenada em X:");
            posicaoX = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a coordenada em Y: ");
            posicaoY = int.Parse(Console.ReadLine());

           PlanoCartesiano coordenadas = new PlanoCartesiano(posicaoX, posicaoY);
            listaCoordenadas.Add(coordenadas);
            //retornando os dados coletados
            return coordenadas;          
        }
        // criando método (parametro de entrada)
        public static void MostrarCoordenadas(PlanoCartesiano exibir)
        {
            Console.WriteLine($"A posição em X é: {exibir.PosicaoX} em X.");
            Console.WriteLine($"A posição em Y é: {exibir.PosicaoY} em Y.");
        }
    }
}






































































































