﻿// See https://aka.ms/new-console-template for more information

Console.WriteLine("Escreva a seqüência de atribuições, \n " + "em forma de programa em C# e no Visual Studio,\n" +
    " para trocar entre \n " +
"si os valores de duas variáveis A e B.");


Console.Write("Digite uma frase qualquer:");
string variavel1 = Console.ReadLine();

Console.Write("Digite uma frase qualquer:"); 
string variavel2 = Console.ReadLine();

Console.WriteLine("O conteudo da variavel1 é:" + variavel1);
Console.WriteLine("O conteudo da variavel2 é:" + variavel2);

Console.WriteLine("Processo de troca entre as duas variáveis:");

string tmp = variavel1;
variavel1 = variavel2;

variavel2 = tmp;

Console.WriteLine("O conteudo da variavel1 é:" + variavel1);
Console.WriteLine("O conteudo da variavel2 é:" + variavel2);






