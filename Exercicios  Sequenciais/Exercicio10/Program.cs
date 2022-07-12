/*10) Um programa para gerenciar os saques de um caixa eletrônico deve possuir algum mecanismo 
para decidir o número de notas de cada valor que deve ser disponibilizado para o cliente que 
realizou o saque. Um possível critério seria o da “distribuição ótima” no sentido de que as 
notas de menor valor fossem distribuídas em número mínimo possível. 
Por exemplo, se a quantia solicitada fosse R$ 87,00 o programa deveria indicar uma nota de R$ 50,00,
três notas de R$ 10,00, uma nota de R$ 5,00 e duas notas de R$ 1,00. 
Escreva um programa que receba o valor da quantia solicitada e retorne a distribuição das notas 
de acordo com o critério da “distribuição ótima”.*/



Console.WriteLine("Bem vindo ao seu banco!");

double saldo = 1000;
Console.WriteLine("Seu saldo é de: " + saldo);

double[] notas = { 200, 100, 50, 20, 10, 5, 2, 1 };
Console.WriteLine("Digite o valor do saque: ");

double valorSaque = double.Parse(Console.ReadLine());
if (saldo >= valorSaque)
{
    double resto = valorSaque;

    for (int indice = 0; indice < notas.Length; indice++)
    {
        if (resto >= notas[indice])
        {
            double qntNotas = resto / notas[indice];
            resto = resto % notas[indice];
            Console.WriteLine("A quantidade de notas de " + notas[indice] + " é " + Math.Floor(qntNotas));
        }
        

    }
}
else
{
    Console.WriteLine("Saldo insuficiente");
}
















   









