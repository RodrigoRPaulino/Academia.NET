/*
 * #4
 * Imagine um jogo com asteroides e uma nave de ataque, que deve destruir os asteróides que voam em todas as direções. 
 * Dessa forma, crie um programa em C# que represente
 * uma lista de asteroides que deveriam ser 'inseridos' no jogo. Para isso, faça uma classe que contenha os atributos 
 * (privados) posição x, posição y (do asteroide em
 * um plano cartesiano), tamanho do asteroide (1 a 10), velocidade do asteroide (1 a 5) e energia (1 a 5). Para esses
 * atributos privados, gerar os métodos de acesso
 * (propriedades getter e setter). Além disso, implementar 3 construtores (sobrecarga): um vazio, outro passando 
 * todos os parâmetros de um objeto tipo Asteroide, e um 
 * terceiro que constrói um asteroide com posição x e posição y. 
 * O programa principal (main) deve conter a lista de Asteroides, preenchida pelo usuário. Nesse programa 
 * principal, construir um método de classe que exiba todos os
 * asteróides da lista.
 * 
 **/



namespace Exercicio4
{
    class Program
    {    // tornamos a lista global
        public static List<Asteroide> listaAsteroides = new List<Asteroide>();
        // void volta vazio

        // main sera a classe principal
        public static void Main()
        {
            // iniciamos o laco de repeticao
            while (true)
            {  // opção de preenchimento de menu
                string opcao;
                Console.WriteLine("============ MENU =================");
                Console.WriteLine("Gostaria de inserir um asteroide (S/N)?");
                opcao = Console.ReadLine().ToLower();
                // condições
                if (opcao == "n")
                {
                    Console.WriteLine("Saindo do programa.");
                    // quebra o laço 
                    break;
                }
                else if (opcao == "s")
                {   // chama o método preencher asteroide
                    PreencherAsteroide();
                }
                else
                {
                    Console.WriteLine("Opção invalida!");
                    // vai voltar ao inicio do while
                    continue;
                }


            }
            // mostrar lista ao usuario a lista montada no preencher asteroides esta sendo passada para o método
            // mostrar asteroides.
            Asteroide.MostrarAsteroides(listaAsteroides);
           

        }
        // criacao de um novo método para preencher os valores
        static void PreencherAsteroide()
        {
            // precisei criar essas variaveis pois os atributos são privados
            // so funcionam dentro desse método
            int posicaoX, posicaoY, tamanho, velocidade, energia;

            Console.WriteLine("1-Digite o valor em X do asteróide:");
            posicaoX = int.Parse(Console.ReadLine());
            Console.WriteLine("2-Digite o valor em Y do asteroide: ");
            posicaoY = int.Parse(Console.ReadLine());
            Console.WriteLine("3-Digite o tamanho do asteroide:");
            tamanho = int.Parse(Console.ReadLine());
            Console.WriteLine("4-Digite a velocidade do asteroide:");
            velocidade = int.Parse(Console.ReadLine());
            Console.WriteLine("5-Digite a energia do asteroide:");
            energia = int.Parse(Console.ReadLine());

            // insiro as informacoes digitadas pelo usuario na lista asteroide
            Asteroide asteroide = new Asteroide(posicaoX, posicaoY, tamanho, velocidade, energia);

            //adicionando informacoes na lista
            listaAsteroides.Add(asteroide);
        }

    }
}





