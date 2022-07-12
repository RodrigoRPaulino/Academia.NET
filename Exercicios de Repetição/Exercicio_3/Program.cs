// See https://aka.ms/new-console-template for more information
Console.WriteLine("Fazer um laço (repetição) que fique solicitando números ao usuário. Se o usuário digitar 0 o programa em VS deve parar.\n" +
    "Caso contrário, o programa em VS deve informar se o número é par ou ímpar e se ele é um número primo.");


int numero;
char novoNumero;
int contador = 0;
while (true)
{
    do
    {
        Console.WriteLine("Digite um número inteiro positivo: ");
        numero = int.Parse(Console.ReadLine());
        if (numero < 0)
        {
            Console.WriteLine("Você deve digitar um número positivo!");
        }
    } while (numero < 0);
    Console.WriteLine($"Número digitado: {numero}.");
    Console.WriteLine($"Números inteiros pares entre 1 e {numero}: ");

    for (int i = 1; i < numero; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine(i + " ");
        }
    } 
    Console.WriteLine("Deseja informar outro número (s/n)? ");
    novoNumero = char.Parse(Console.ReadLine());

    if (novoNumero == 'n' || novoNumero == 'N')
    {
        break;
    }
}






















