// See https://aka.ms/new-console-template for more information

/*
 * Escreva um programa em C# e no Visual Studio para calcular a média 
 * aritmética entre quatro números quaisquer.
 */

Console.WriteLine("Exercicio 2: Escreva um programa em C# e no Visual Studio \n" +
    " para calcular a média  aritmética entre quatro números quaisquer.");

float numero1;
float numero2;
float numero3;
float numero4;
float mediaAritmetica;

Console.Write("Informe o 1° número:");
numero1 = float.Parse(Console.ReadLine());


Console.Write("Informe o 2° número:");
numero2 = float.Parse(Console.ReadLine());


Console.Write("Informe o 3° número:");
numero3 = float.Parse(Console.ReadLine());


Console.Write("Informe o 4° número:");
numero4 = float.Parse(Console.ReadLine());

mediaAritmetica = (numero1 + numero2 + numero3 + numero4) / 4;

Console.WriteLine("A média dos 4 valores é:" + mediaAritmetica);







