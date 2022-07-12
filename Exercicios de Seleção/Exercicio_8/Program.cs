// See https://aka.ms/new-console-template for more information
Console.WriteLine("Faça um programa no VS que receba o código, nome, salário base e o total de vendas de um funcionário.\n" +
    "Caso o total de vendas seja acima de R$ 500, 00, adicionar ao seu salário final\n" +
    " 5 % do total de vendas.Caso o total de vendas seja mais que R$ 1000,00, \n" +
    "adicionar ao seu salário final 7% do total de vendas.E por fim, se o total de vendas seja maior que R$ 5000,00,\n" +
    " adicionar ao seu salário final 10% do total de vendas. ");
int codigoFuncionario;
string  nomeFuncionario;
double salarioBase;
double totalVendas;
double salarioTotal;

double porcentagem5 = 5;


double porcentagem7 = 7;


double porcentagem10 =10;


Console.Write("Insira seu código de funcionário: ");
codigoFuncionario = int.Parse(Console.ReadLine());

Console.Write("Insira seu nome: ");
nomeFuncionario = Console.ReadLine();

Console.Write("Informe seu salario base: ");
salarioBase = double.Parse(Console.ReadLine());

Console.Write("Informe o total de vendas em R$: ");
totalVendas = double.Parse(Console.ReadLine());

if (totalVendas > 500 && totalVendas < 1000)
{
    double aumento5 = (totalVendas * porcentagem5) /100;
    salarioTotal = aumento5 + salarioBase;
    Console.WriteLine("O salario total é de: " + salarioTotal);
}
else if (totalVendas >1000 &&  totalVendas < 5000)
{
    salarioTotal = (totalVendas * porcentagem7) /100;
    Console.WriteLine("O salario total é de: " + salarioTotal);
}
else if (totalVendas > 5000)
{
    salarioTotal = (totalVendas * porcentagem10) / 100;
    Console.WriteLine("O salário total é de: " + salarioTotal);
}
else
{

}
 





