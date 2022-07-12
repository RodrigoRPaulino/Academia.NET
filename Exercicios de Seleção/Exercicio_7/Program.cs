// See https://aka.ms/new-console-template for more information
Console.WriteLine(" Faça um programa em C# e no VS para receber uma frase qualquer e uma palavra de pesquisa.\n" +
    "O programa deve avaliar se a palavra aparece na frase, informando o usuário via mensagem,\n" +
    " como por exemplo, A palavra encontra - se na frase   ou A palavra não se encontra na frase.");

string frase;
string[] palavras;
string pesquisador;


Console.Write("Digite uma frase qualquer:");
frase = Console.ReadLine();
Console.WriteLine("A frase digitada foi: " + frase);

Console.Write("Digite uma palavra para pesquisar na frase: ");
pesquisador = Console.ReadLine();
Console.WriteLine("O resultado da pesquisa é: " + frase.Contains(pesquisador));



