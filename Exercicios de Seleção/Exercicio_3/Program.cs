// See https://aka.ms/new-console-template for more information
Console.WriteLine("Escrever um algoritmo para ler quatro valores inteiros, calcular a sua média,\n" +
    " escrever na tela os que são superiores à média.");

Console.WriteLine("Insira o primeiro valor:");
int valor1 = int.Parse(Console.ReadLine());

Console.WriteLine("Insira o segundo valor:");
int valor2 = int.Parse(Console.ReadLine());

Console.WriteLine("Insira o terceiro valor:");
int valor3 = int.Parse(Console.ReadLine());

Console.WriteLine("Insira o quarto valor:");
int valor4 = int.Parse(Console.ReadLine());

int media = (valor1 + valor2 + valor3 + valor4) / 4;
    Console.WriteLine("O valor da média é : " + media);


