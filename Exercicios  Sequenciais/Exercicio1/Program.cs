
// See https://aka.ms/new-console-template for more information
// 1) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre dois números quaisquer.

Console.WriteLine(" Escreva um programa em C# e no Visual Studio \n" +
    " para calcular a média aritmética entre dois números quaisquer.");

float numero1;
float numero2;
float mediaAritmetica;

Console.WriteLine("Digite um numero qualquer");
numero1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite um segundo numero qualquer");
numero2 = float.Parse(Console.ReadLine());

mediaAritmetica = (numero1 + numero2) / 2;

Console.WriteLine("a media aritmetica é:" + mediaAritmetica);








