// See https://aka.ms/new-console-template for more information
Console.WriteLine(" Escreva um programa em C# e no Visual Studio que leia os dados para o \n" +
    " parafuso A e para o parafuso B, \n" +
    "isto é, o código, a quantidade de peças e  \n" +
    "o valor unitário de cada parafuso e a porcentagem de IPI(única) a ser acrescentada. ");
// pode- se fazer uma lista de parafusos

Console.Write("Entre com o código do parauso A: ");
int parafusoA = int.Parse(Console.ReadLine());

int codigoA = parafusoA;
Console.WriteLine("O código do parauso A é:" + codigoA);

Console.Write("Entre com a quantidade de peças: ");

int quantidadeA = int.Parse(Console.ReadLine());
Console.WriteLine("A quantidade do parafuso A é :" + quantidadeA +" peças");

Console.Write("Informe o valor do item A:");
double valor_A = double.Parse(Console.ReadLine());
Console.WriteLine("O valor do item A é: R$ " + valor_A + Math.Floor(valor_A));

Console.Write("Informe a porcentagem do IPI (%) do item A :");
double ipi = double.Parse(Console.ReadLine());

Console.WriteLine ("O IPI do item A é: " +ipi);
ipi = valor_A * 0.12 + quantidadeA;

Console.WriteLine("O valor total do item A é: R$ " +ipi);

//Parafuso B:


Console.Write("Entre com o código do parauso B: ");
int parafusoB = int.Parse(Console.ReadLine());

int codigoB = parafusoB;
Console.WriteLine("O código do parauso B é:" + codigoB);
Console.Write("Entre com a quantidade de peças: ");

int quantidadeB = int.Parse(Console.ReadLine());
Console.WriteLine("A quantidade do parafuso B é :" + quantidadeB + " peças");

Console.Write("Informe o valor do item B:");
double valor_B = double.Parse(Console.ReadLine());
Console.WriteLine("O valor do item B é: R$ " + valor_B + Math.Floor(valor_B));

Console.Write("Informe a porcentagem do IPI (%) do item A :");
double ipiB = double.Parse(Console.ReadLine());

Console.WriteLine("O IPI do item A é: " + ipi);
ipi = valor_B * 0.12 + quantidadeB;

Console.WriteLine("O valor total do item B é: R$ " + ipi);






















