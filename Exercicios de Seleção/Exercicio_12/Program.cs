// See https://aka.ms/new-console-template for more information
Console.WriteLine(" Elabore um programa em VS que leia as variáveis codigo e numeroHoras, respectivamente\n" +
    " código e número de horas trabalhadas de um operário.Na sequência, calcule o salário\n" +
    " sabendo - se que ele ganhaR$ 10, 00 por hora.Quando o número de horas exceder a 50\n" +
    " calcule o excesso de pagamento armazenando - o na variável\n" +
    " extra, caso contrário zerar tal variável.A hora excedente de trabalho\n" +
    " vale R$ 20, 00.No final do processamento, exibir o salário total e o salário excedente do operário.");

int codigo;
// horas fixas por dia empregado CLT
int jornadaDiaria = 8;
int jornadaMensal = 160;
// horas trabalhadas
float nrHoras;
float salarioBase = 1000;
// total do salrio do funcionario
float salarioTotal ;
// vaor da hora normal do funcionario
float valoHoraTrab; 
// hora extra exedente a 50 horas
float hrExedente;

float extra;



/// <summary>
/// coletar do usuario o codigo, o numero de horas trabalhadas e o salario base
/// </summary>
Console.Write("Digite seu código: ");
codigo = int.Parse(Console.ReadLine());

Console.Write("Digite o número de horas trabalhadas neste mês : ");
nrHoras = float.Parse(Console.ReadLine());


valoHoraTrab = salarioBase / jornadaDiaria * 20;   // valor em 20 dias
Console.WriteLine($"Seu salário por hora é de {valoHoraTrab}");

hrExedente = nrHoras - jornadaMensal;

if (nrHoras > jornadaMensal && hrExedente < 50) 
{
    extra = (hrExedente * 10);
    Console.WriteLine($"O valor da  hora extra é de R$ : {extra} reais neste mês.");
    salarioTotal = salarioBase + extra;
    Console.WriteLine("O salario total é R$ :" + salarioTotal);
}
else if (nrHoras > jornadaMensal && hrExedente > 50)
{
    float horaAux = hrExedente - 50;
    extra = (horaAux * 20) + (50 *10);

    Console.WriteLine($"O valor da  hora extra é de R$ : {extra} reais neste mês.");
    salarioTotal = salarioBase + extra;
    Console.WriteLine("O salario total é R$ :" + salarioTotal);
    
}
else
{
    Console.WriteLine("Você nao fez horas extras esse mes.");
}
