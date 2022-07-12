// See https://aka.ms/new-console-template for more information
Console.WriteLine("Uma loja vende bicicletas com um acréscimo de 50% sobre o preço de custo. Ela paga a cada vendedor\n" +
    " 2 salários mínimos mensais, mais uma comissão de 15% sobre o preço de custo de cada bicicleta vendida.\n" +
    "Desenvolva um algoritmo que leia o valor do salário mínimo, o preço de custo de cada bicicleta\n" +
    " e o número de bicicletas vendidas pelo vendedor, calcule e mostre: o salário do empregado");

double salmin, custo, qtdBici, salemp, pvenda, comissao;
Console.WriteLine(" Digite o valor do salario minimo: ");
salmin = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o preço de custo da bicicleta: ");
custo = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o numero de bicicletas vendidas pelo vendedor ");
qtdBici = double.Parse(Console.ReadLine());
// ou e 233 * 1.5

salemp = (salmin * 2) + (custo * 0.15 * qtdBici);

Console.WriteLine("O salario total do vendedor é :" + salemp);
;




