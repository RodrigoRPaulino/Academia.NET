// See https://aka.ms/new-console-template for more information
Console.WriteLine("Faça um programa em C# e no Visual Studio para receber o nome (totalmente em maiúsculo),\n" +
    " a altura (metros) e o peso (kg) de uma pessoa.O programa deve calcular o Indice de Massa Corpórea(IMC),\n" +
    " exibi - lo ao usuário e informar sua situação conforme a tabela.\n" +
    "O cálculo do imc = peso / (altura * altura)");
/*IMC 
menor que 18                -> baixo peso
maior que 18 e menor que 25 -> peso normal
maior que 25 e menor que 30 -> sobrepeso
maior que 30 e menor que 35 -> obesidade
maior que 35                -> obesidade grau sério */

string nome;
double altura;
double peso;
double imc;

Console.Write("Digite seu nome :");
nome = Console.ReadLine();
nome = nome.ToUpper();
Console.WriteLine($" Seu nome é:" + nome);

Console.Write("Digite sua altura:");
altura =double.Parse(Console.ReadLine());

Console.Write("Digite seu peso atual :");
peso = double.Parse(Console.ReadLine());

imc = peso / (altura * altura);


if (imc < 18)
{
    Console.WriteLine("Você esta abaixo do peso ideal.");
}
else if (imc > 18 && imc < 25)
{
    Console.WriteLine("Você esta no seu peso ideal ! ");
}
else if (imc > 25 && imc < 30)
{
    Console.WriteLine("Você esta com sobrepeso.");
}
else if (imc > 30 && imc < 35)
{
    Console.WriteLine("Você sofre de Obesidade.");
}
else
{
    Console.WriteLine("Você sofre de Obesidade mórbida.");
}

Console.WriteLine("Seu IMC é de:" + imc);