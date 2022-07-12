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



using Exercicio2;
List<Cachorro> cachorros = new List<Cachorro>();
List<Gato> gatos = new List<Gato>();
List<Peixe> peixes = new List<Peixe>();

string opcao;


do
{
    Console.WriteLine("Digite a opção do animal que você deseja inserir:");
    Console.WriteLine("1- Inserir cachorro: ");
    Console.WriteLine("2- Inserir gato: ");
    Console.WriteLine("3- Inserir peixe: ");
    Console.WriteLine("4- Mostrar animais cadastrados: ");
    Console.WriteLine("5- Sair: ");
    Console.Write("Opçao: ");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            cachorros.Add(Cachorro.InserirCachorro());
            break;
        case "2":
            gatos.Add(Gato.InserirGato());
            break;
        case "3":
            peixes.Add(Peixe.InserirPeixe());
            break;
        case "4":
            Console.WriteLine("Exibindo a lista de animais cadastrados");
            MostarSubMenu(cachorros, gatos, peixes);
            
            break;

        default:
            Console.WriteLine("Opção inválida!");
            break;

    }
    Console.Clear();
    Console.Write("Pressione qualquer tecla para continuar!: "); Console.ReadKey();



} while (opcao != "5");

static void MostarSubMenu(List<Cachorro> cachorros, List<Gato> gatos, List<Peixe> peixes)
{



    bool ficar = true;
    while (ficar)
    {
        Console.WriteLine("Quais animais você quer listar?");
        Console.WriteLine("1- Mostrar cachorro: ");
        Console.WriteLine("2- Mostrar gato: ");
        Console.WriteLine("3- Mostrar peixe: ");
        Console.WriteLine("4- Mostrar todos os animais");
        Console.WriteLine("5- Sair");
        Console.Write("Opção: ");
        string opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                Cachorro.ListarCachorros(cachorros);
                break;
            case "2":
                Gato.ListarGatos(gatos);
                break;
            case "3":
                Peixe.ListarPeixes(peixes);
                break;
            case "4":
                Console.WriteLine($"Temos um total de: {cachorros.Count() + gatos.Count() + peixes.Count()} de animais.");
                Cachorro.ListarCachorros(cachorros);
                Gato.ListarGatos(gatos);
                Peixe.ListarPeixes(peixes);
                break;

            case "5":
                ficar = false;
                break;
            default:
                Console.WriteLine("Opção invalida! Tente novamente.");
                break;

        }
      
    }
}