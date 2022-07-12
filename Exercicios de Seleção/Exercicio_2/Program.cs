// See https://aka.ms/new-console-template for more information
Console.WriteLine(" Faça um algoritmo para ler um número e verificar se ele é par ou ímpar.");





    int valor;
    Console.WriteLine("Digite um numero");
    valor = int.Parse(Console.ReadLine());

    if (valor > 0 && valor % 2 == 0)
    {
        Console.WriteLine("O número digitado e par!");
    }
    else
    {
        Console.WriteLine("O número digitado e impar!");
    }
 



