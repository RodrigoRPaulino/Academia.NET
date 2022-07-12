// See https://aka.ms/new-console-template for more information


//    "Note que o dia, o mês e o ano devem ser lidos em variáveis diferentes.");
//metodo de resolucao usando o int
//solucao classica e basica
Console.WriteLine("Faça um programa em C# e no Visual Studio \n" +
    " que receba a data na forma DDMMAAAA e imprima na forma AAAAMMDD e AAMMDD.\n ");

int dia;
int mes;
int ano;

Console.Write("Digite o dia:");
dia = int.Parse(Console.ReadLine());

 
Console.Write("Digite o mês:");
 mes = int.Parse(Console.ReadLine());

Console.Write("Digite o ano:");
 ano = int.Parse(Console.ReadLine());
Console.WriteLine("AAAA/MM/DD " + ano +  "/" + mes +  "/" + dia);
Console.WriteLine("AA/MM/DD " + (ano % 100) + "/" + mes + "/" + dia);

//Resolvendo por string (Solução não classica)

//string dia;
//string mes;
//string ano;

//Console.Write("Informe o dia: ");
//dia = Console.ReadLine();

//Console.Write("Informe o mês: ");
//mes = Console.ReadLine();

//Console.Write("Informe o ano: ");
//ano = Console.ReadLine();

//Console.WriteLine("DD/MM/AAAA: " + dia + "/" + mes + "/" + ano);
//Console.WriteLine("AAAA/MM/DD: " + ano + "/" + mes + "/" + dia);

//Console.WriteLine("AA/MM/DD: " + ano[2] + ano[3] + "/" + mes + "/" + dia);














