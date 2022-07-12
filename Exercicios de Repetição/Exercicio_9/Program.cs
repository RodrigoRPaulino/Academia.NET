// See https://aka.ms/new-console-template for more information
Console.WriteLine("Faça um programa em VS para Ler a quantidade de filhos de cada uma das 30 pessoas que visitaram o zoológico num determinado dia,\n" +
    " imprimindo:Quantas pessoas tem entre 1 e 3 filhos.Quantas pessoas tem entre 4 e 7 filhos.Quantas pessoas tem mais de 8 filhos.\n" +
    "Quantas pessoas não tem filhos.");








Console.WriteLine("========== CONTROLE DE PESSOAS ================");
Console.Write("DIGITE A QUANTIDADE DE PESSOAS: ");
int qtdPessoas = int.Parse(Console.ReadLine());

List<Pessoa> pessoaSemFilho = new List<Pessoa>();
List<Pessoa> pessoaAte4 = new List<Pessoa>();
List<Pessoa> pessoaAte8 = new List<Pessoa>();
List<Pessoa> pessoaSemTV = new List<Pessoa>();


try
{
int qtd = 0;
int visu = 0;
for (int i = 0; i < qtdPessoas; i++)
{
Console.Clear();
if (visu > 0)
{
Console.WriteLine($"{visu} Pessoas Cadastradas");
}
Console.Write("Digite o nome da Pessoa: ");
string Nome = Console.ReadLine();
Console.Write("Digite a quantidade de filhos: ");
qtd = int.Parse(Console.ReadLine());
visu++;

if (qtd == 0)
{
pessoaSemFilho.Add(new Pessoa { Nome = Nome, QuantidadeFilhos = qtd });
}
else if (qtd >= 1 && qtd <= 4)
{
pessoaAte4.Add(new Pessoa { Nome = Nome, QuantidadeFilhos = qtd });
}
else if (qtd > 4 && qtd <= 8)
{
pessoaAte8.Add(new Pessoa { Nome = Nome, QuantidadeFilhos = qtd });
}
else
{
pessoaSemTV.Add(new Pessoa { Nome = Nome, QuantidadeFilhos = qtd });
}
}
Console.WriteLine("Resumo do Controle\n");
Console.Write($"Quantidade de pessoas sem filhos: {pessoaSemFilho.Count}\n");
Console.Write($"Quantidade de pessoas com até 4 filhos: {pessoaAte4.Count}\n");
Console.Write($"Quantidade de pessoas com 5 até 8 filhos: {pessoaAte8.Count}\n");
Console.Write($"Quantidade de pessoas acima de 8 filhos: {pessoaSemTV.Count}\n");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
public class Pessoa
{
    public string Nome { get; set; } = String.Empty;
    public int QuantidadeFilhos { get; set; } = 0;
}






















































//Console.WriteLine("Digite a quantidade de filhos do visitante.");
//filhos = int.Parse(Console.ReadLine());

//while (true) 
//{  if (filhos > 0 && filhos < 4)
//    {
//        Console.WriteLine("O visitante possui de 1 a 3 filhos.");

//    }
//   if (filhos > 3 && filhos < 8)
//    {
//        Console.WriteLine("O visitante possui de 4 a 7 filhos.");

//    }
//   if (filhos > 8)
//    {
//        Console.WriteLine("O visitante possui mais de 8 filhos.");

//    }
//   else if (filhos == 0)
//    {
//        Console.WriteLine("O visitante não possui filhos.");

//    }







//} 





