/*Crie uma classe para representar um item de cenário, com os atributos privados de:
    *descrição(string), 
    *data de criação(date - https://docs.microsoft.com/en-us/dotnet/api/system.datetime.date?view=net-6.0) e
    *altura(float).

Crie os métodos públicos necessários para sets e gets, o construtor básico e também um método para imprimir 
todos dados de um item de cenário. 
Por fim, crie um método para calcular a quanto tempo o item foi criado, além de um programa em C# para testar
a classe criada.*/
// instancia do namespace onde está  a classe

namespace Exercicio5
{   
  
    class Program
    {   // a main e sempre um método
        public static void Main()
        {   // apos preencher os dados o return volta pra preencher dados
            Cenario cenario = PreencherDados();
            //mostra os dados preenchidos do cenario que veio da linha acima
            MostrarDados(cenario);
            CalcularTempo(cenario);
        }
        // sempre fazer novos metodos depois da main
        public static Cenario PreencherDados()
        {
            string descricao;
            DateTime dataCriacao;
            float altura;
            // coletando dados do usuario
            Console.WriteLine("Digite a descrição do item  que deseja inserir: ");
            descricao = Console.ReadLine();
            Console.WriteLine("Digite a data de entrada do item:");
            dataCriacao = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura do item:");
            altura = float.Parse(Console.ReadLine());
            
            Cenario novoCenario = new Cenario(descricao, dataCriacao, altura);
            // retorna os dados para preencher cenario na main 
            return novoCenario;
        }
         //               no parentese desse método (parametro de entrada) crio um nome para mostrar o item
         //               
        public static void MostrarDados(Cenario mostrar)
        {
            Console.WriteLine($"A descricao do cenario é {mostrar.Descricao} na data {mostrar.DataCriacao.ToString("dd dddd/MMM/yyyy")}\n" +
                $"com a altura {mostrar.Altura}.");
        }
        public static void CalcularTempo(Cenario calcular)
        { // quanto eu declaro a variável como var estou pedindo para o programa adequar o tipo da variavél recomendada
          var diaEntrada = DateTime.Now.AddYears( - calcular.DataCriacao.Year);
            diaEntrada = diaEntrada.AddMonths( - calcular.DataCriacao.Month);
            diaEntrada= diaEntrada.AddDays( - calcular.DataCriacao.Day);
            
            Console.WriteLine($"O tempo de criação do item é: {diaEntrada.Day} dias {diaEntrada.Month} meses e {diaEntrada.Year} anos.");
        }


    }
}
