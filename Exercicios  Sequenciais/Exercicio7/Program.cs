// See https://aka.ms/new-console-template for more information
Console.WriteLine(" Escreva um programa em C# e no Visual Studio que leia o número de um vendedor,\n" +
    " o seu salário fixo,o total de vendas por ele efetuadas e o percentual que ganha sobre o total de vendas.\n" +
    "Calcule o salário total do vendedor.Escreva o número do vendedor e o salário total do vendedor.");


//parte1:ler dados do vendedor(numero, salário, total de vendas, e comissão)
Console.Write("Informe seu código de vendedor:");

/*int vendedor1;
int vendedor2;
int vendedor3;

int totalVendas1;
int totalVendas2;
int totalVendas3;

int percentualVendas = 15;

double valorCamiseta = 50.00;
double valorCalca = 80.00;
double valorBlusa = 120.00;




vendedor1 = int.Parse(Console.ReadLine());

Console.WriteLine("José, seu código de vendas é: " +vendedor1);

double salario1 = 1500.00;
Console.WriteLine("Seu salario fixo é R$ " + salario1);

Console.WriteLine("Digite o total de vendas efetuadas: ");
totalVendas1 = int.Parse(Console.ReadLine());
Console.WriteLine("A quantidade de vendas total é de :" + totalVendas1+ "vendas.");*/




Console.WriteLine("Informe seu código de vendedor: ");

int[] vendedores = { 1, 2, 3 };
Console.WriteLine("Escolha seu código de vendedor");
int somaValores = 0;

foreach (int v in vendedores)
    
{
  Console.WriteLine(v);
}   

int numeroVendedor = int.Parse(Console.ReadLine());
double salario = 0;
if (numeroVendedor == 1)
{
     salario = 1500;
}
else if (numeroVendedor == 2)
{
     salario = 1850;
}
else
{
     salario = 2300;
}

string[] produtos = { "Calça", "Camiseta", "Blusa"};
int[] valoresProdutos = { 50, 80, 200 };
int[] porcentagemVendas = { 5, 8, 10 };
int[] quantidadeProduto = new int[3];

for (int indice = 0; indice < produtos.Length; indice++)
{
    Console.WriteLine($"O vendedor vendeu quantas {produtos[indice]}");
    quantidadeProduto[indice] = int.Parse(Console.ReadLine());

}

for (int indice = 0; indice < produtos.Length; indice++)
{
    Console.WriteLine($"O vendedor {numeroVendedor} vendeu {quantidadeProduto[indice]} {produtos[indice]}");
    somaValores += valoresProdutos[indice] * quantidadeProduto[indice];
}
Console.WriteLine($"Seu salario fixo e de R$: {salario} ");
Console.WriteLine($"Sua comissão total foi de: {somaValores}");
Console.WriteLine($"Seu salario total referente a este mes foi: {salario + somaValores} ");




























































