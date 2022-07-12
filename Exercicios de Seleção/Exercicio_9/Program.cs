// See https://aka.ms/new-console-template for more information
Console.WriteLine("Faça um programa no VS que receba do usuário 3 valores de glicemia em jejum,\n" +
    " representando a medição diária de um paciente diabético.Para cada valor recebido analisar e informar ao paciente o seguinte:\n" +
    "Se o valor diário for menor que 65, avisá - lo que corre risco de hipoglicemia Se o valor diário for maior que 250,\n" +
    " avisá - lo que corre risco de hiperglicemia.");


/// <summary>
/// armazena a medida glicemica de um dia em jejum
/// </summary>
int medicao1;
/// <summary>
/// armazena a medida glicemica do segundo dia em  jejum
/// </summary>
int medicao2;
/// <summary>
/// armazena a medida glicemica do terceiro dia em jejum
/// </summary>
int medicao3;
/// <summary>
/// armazena a média glicemica e informa se havera aumento oudiminuição de insulina
/// </summary>
float mediaMedicao;


Console.Write("Digite o valor da gliemia em jejum no primeiro dia: ");
medicao1 = int.Parse(Console.ReadLine());

if (medicao1 < 65)
{
    Console.WriteLine("Paciente com risco de hipoglicemia: ");
}
 
if (medicao1 > 250)
{
    Console.WriteLine("Paciente com risco de hiperglicemia: ");
}

Console.Write("Digite o valor da glicemia em jejum do segundo dia: ");
medicao2 = int.Parse(Console.ReadLine());
if (medicao2 < 65)
{
    Console.WriteLine("Paciente com risco de hipoglicemia: ");
}
if (medicao2 > 250)
{
    Console.WriteLine("Paciente com risco de hiperglicemia: ");
}

Console.Write("Digite o valor da glicemia em jejum no terceido dia: ");
medicao3 = int.Parse(Console.ReadLine());
if (medicao3 < 65) 
{
    Console.WriteLine("Paciente com risco de hipoglicemia: ");
}
if (medicao3 > 250)
{
    Console.WriteLine("Paciente com risco de hiperglicemia: ");

}
/*Além disso, o programa deve fazer a média dos 3 valores de glicemia coletados. E se a média for 
menor que 80, avisá-lo que é preciso diminuir 2 unidades de insulina. Se a média for maior que
150, avisá-lo que será necessário adicionar 2 unidades de insulina.*/

mediaMedicao = (medicao1 + medicao2 + medicao3) / 3;
Console.WriteLine($"A média glicemica do paciente é de {mediaMedicao } mg/ml");

if (mediaMedicao < 80)
{
    Console.WriteLine("Paciente precisa diminuir 2 unidades de insulina.");
}
if (mediaMedicao > 150)
{
    Console.WriteLine("Paciente precisa aumentar 2 unidades de insulina.");
}
