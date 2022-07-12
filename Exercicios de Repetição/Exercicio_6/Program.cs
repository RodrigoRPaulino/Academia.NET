// See https://aka.ms/new-console-template for more information
Console.WriteLine(" Faça um programa em VS que solicite ao o usuário que informe a idade e valide a entrada de dados, \n" +
    "ou seja, repita a leitura até que ela esteja correta(maior do que zero). Ao final, mostre a idade digitada.");


int idade;
Console.WriteLine("Digite a sua idade: ");
idade = int.Parse(Console.ReadLine());

while (idade > 0)
{
    Console.WriteLine($"A idade Informada foi: {idade}");
    break;

}