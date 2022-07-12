// See https://aka.ms/new-console-template for more information
Console.WriteLine("Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores\n" +
    " o valor por hora recebido por cada um deles. Mostrar na tela qual dos professores tem o maior salário total.");

decimal professor1;
decimal professor2;
decimal calculo1;

decimal salario1;
decimal salario2;
decimal calculo2;

decimal maiorSalario;



Console.WriteLine("Digite a quantidade de horas trabalhadas do professor1: ");
professor1 = decimal.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor da hora aula do professor 1 : ");
salario1 = decimal.Parse(Console.ReadLine());
calculo1 = professor1 * salario1;
Console.WriteLine("seu salario é de :" + calculo1);

Console.WriteLine("Digite a quantidade de horas trabalhadas do professor 2: ");
professor2 = decimal.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor da hora aula do professor 2 :");
salario2 = decimal.Parse(Console.ReadLine());

calculo2 = professor2 * salario2;
Console.WriteLine("O salario do professor 2 é: " + calculo2);

if (calculo1 > calculo2)
{
    Console.WriteLine("O maior salario total é o salario do professor 1");
}

if (calculo1 < calculo2)
{
    Console.WriteLine("O maior salario total é o salario do professor 2");
}
else
{

}










