// See https://aka.ms/new-console-template for more information
Console.WriteLine("Faça um programa em VS que solicite o nome, a idade e o salário de uma pessoa.\n" +
    " A cada solicitação, teste se o usuário informou um valor válido.Por exemplo: se o nome não for lido corretamente\n" +
    " (ou seja, se estiver em branco ou se for um número), informe que ele está incorreto e saia do programa em VS.\n" +
    " Se o nome for lido corretamente, solicite a idade. Se ela for incorreta (menor ou igual a zero),\n" +
    " informe que está errada e saia. Se estiver correta, solicite o salário.\n" +
    " Se ele estiver incorreto (menor ou igual a zero), informe que está incorreto e saia. Se estiver correto, mostre todos os valores lidos.");


// declarando as variaveis 
string nome;
int idade;
decimal salario;

while (true)
{
    
    Console.Write($"Digite seu nome: ");
    nome = Console.ReadLine();

   if  (string.IsNullOrEmpty(nome))
    {
        Console.WriteLine("O nome deve ser preenchido corretamente! ");
        break;
    }
   
    Console.Write($"Digite sua idade:");
    idade = int.Parse(Console.ReadLine());

    if (idade <= 0)
    {
        Console.WriteLine("idade invalida!");
        break;
    }
    
    Console.Write($"Digite o valor do seu salário: ");
    salario = decimal.Parse(Console.ReadLine());

    if (salario <= 0)
    {
        Console.WriteLine("Salário inválido!");
        break;
    }
    Console.WriteLine($"Seu nome é:{nome}.");
    Console.WriteLine($"Sua idade é: {idade} anos.");
    Console.WriteLine($"seu salário é: {salario} reais.");
    
    break;    
} 