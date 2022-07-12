// See https://aka.ms/new-console-template for more information
Console.WriteLine(" Faça um programa em VS que solicite um número inteiro positivo ao usuário, validando a entrada de dados\n" +
    " (informando se ele estiver errado e repetindo a solicitação até que esteja correto).\n" +
    "Após o programa em VS deve informar todos os números pares existentes\n" +
    " entre 1 e o número fornecido pelo usuário.");

// declarando as variáveis ultilizadas
int numeros;

int i = 0;
// faça
do
{   //Coletando informações do usuário
    Console.Write($"Digite um numero inteiro positivo: ");
    numeros = int.Parse(Console.ReadLine());
    Console.WriteLine($"Voce digitou o numero {numeros}");
 
    // se (variavel for menor que 0)
    if (numeros < 0)
    {
        Console.WriteLine("O numero digitado deve ser positivo!");
    }
   

    //  e se 
    if (i < numeros)
    {// para
        for (i = 0; i <= numeros; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine($"Os numeros pares exixtentes deste numero são : {i}");
            }
           
        }
    }
// enquanto (verdadeiro ou falso)
} while (true);





