// See https://aka.ms/new-console-template for more information
Console.WriteLine("Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra “Aprovado” \n" +
    "se a média das duas notas for maior ou igual a 7, 0.Caso a média seja inferior a 7, 0,\n" +
    " o programa deve ler a nota do exame e calcular a média final,é a média entre\n" +
    " a nota do exame e a média das 2 notas. Se esta média final for maior ou igual a 5,0,\n" +
    " o programa deve escrever “Aprovado”, caso contrário deve escrever “Reprovado”.");

float nota1;
float nota2;
float mediaNota;
float notaExame;
float mediaFinal;

Console.Write("Insira a primeira nota do aluno:");
nota1 = float.Parse(Console.ReadLine());

Console.Write("Insira a segunda nota do aluno");
nota2 = float.Parse(Console.ReadLine());

Console.WriteLine("Insira a nota do Exame:");
notaExame = float.Parse(Console.ReadLine());

mediaNota = (nota1 + nota2) /2;
mediaFinal = (mediaNota + notaExame) /2;

if (mediaNota >= 7)
{
    Console.WriteLine("Aluno Aprovado.");
}
else if (mediaFinal >= 5)
{
    Console.WriteLine("Aluno Aprovado por Média.");
}
else
{
    Console.WriteLine("Aluno Reprovado.");
}

 














