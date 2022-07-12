// See https://aka.ms/new-console-template for more information
Console.WriteLine("Faça um programa no VS que receba dados de dois atletas (nome, idade e altura).\n" +
    "O programa deve mostrar os dados do atleta mais novo e mais alto.");

string nome1;
string nome2;
int idade1;
int idade2;
float altura1;
float altura2;



Console.Write("Digite o nome do atleta n° 1: ");
nome1 = Console.ReadLine();

Console.Write("Digite a idade do atleta n° 1: ");
idade1 = int.Parse(Console.ReadLine());

Console.Write("Digite a altura do atleta n° 1: ");
altura1 = float.Parse(Console.ReadLine());




Console.WriteLine("Digite o nome do atleta n° 2: ");
nome2 = Console.ReadLine();

Console.WriteLine("Digite a idade do atleta n° 2: ");
idade2 = int.Parse(Console.ReadLine());

Console.Write("Digite a altura do atleta n° 2: ");
altura2 = float.Parse(Console.ReadLine());

if (idade1 < idade2 && altura1 > altura2)
{
    Console.WriteLine("O atleta n° 1 e mais novo e mais alto.");
}

else
{
    Console.WriteLine("O atleta n° 2 e mais novo e mais alto.");
}

