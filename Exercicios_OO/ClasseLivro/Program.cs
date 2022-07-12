// See https://aka.ms/new-console-template for more information
using ClasseLivro;

Console.WriteLine("Hello, World!");

string t, a;
int pag, ano, ed;
Console.WriteLine("Digite o titulo do livro: ");
t = Console.ReadLine();
Console.WriteLine("Digite o autor do livro: ");
a = Console.ReadLine();
Console.WriteLine("Digite a quantidade de paginas: ");
pag = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o ano de publicação do livro: ");
ano = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a edição do livro: ");
ed = int.Parse(Console.ReadLine());

Livro l1 = new Livro(t, a, pag, ano, ed);
l1.apresentaInfoLivro();


