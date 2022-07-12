// See https://aka.ms/new-console-template for more information
Console.WriteLine("Faça um programa em VS que solicite um numero inteiro. Se o numero não for inteiro, solicite - o até que seja.\n" +
    "após, informe se ele é par ou impar.Finalmente, pergunte ao usuário se ele quer repetir o programa em VS.");


int numero;
char novoNumero;

while (true)
{
    Console.WriteLine("Digite um número inteiro:");
    if (!int.TryParse(Console.ReadLine(), out numero))
    {
        Console.WriteLine("Insira apenas números inteiros!");
    }
    if (numero > 0 && numero % 2 == 0)
    {
        Console.WriteLine("O número informado é par.");
    }
    else if (numero > 0 && numero % 2 != 0)
    {
        Console.WriteLine("O número informado é impar.");
    }
    Console.WriteLine("Deseja informar outro numero (S/N)?");
    novoNumero = char.Parse(Console.ReadLine());

    if (novoNumero == 'n' || novoNumero == 'N')
    {
        break;
    }

}








