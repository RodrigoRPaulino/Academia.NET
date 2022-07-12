// See https://aka.ms/new-console-template for more information
Console.WriteLine("Em uma cidadezinha do interior há dois candidatos para prefeito (JOAO e ZECA). Você foi contratado\n" +
    " para fazer um programa em VS que conte os votos dos candidatos.Cada vez que o usuário digitar JOAO,\n" +
    " você deve somar um ao seu número de votos.O mesmo para ZECA.Você também pode aceitar\n" +
    " votos em branco(palavra BRANCO).O programa em VS termina quando o usuárioescrever FIM.\n" +
    "Ao final devem ser mostradas as quantidades de votos para cada um dos candidatos e o número de votos em branco. ");
/*
 * Modifique o programa em VS anterior para aceitar votos nulos 
(qualquer nome diferente de FIM, JOAO, ZECA e BRANCO). 
Ao final, informe o nome do candidato vencedor, o número de votos nulos 
e o número de pessoas que votaram.*/

string voto;
int totalVotosZeca = 0;
int totalVotosJoao = 0;
int totalVotosBranco = 0;

do
{
    Console.Write("Digite o nome do seu candidato ou branco ou fim para encerrar: ");
    voto = Console.ReadLine().ToUpper();  
    switch (voto)
    {
        case "Joao":
            totalVotosJoao++;
            Console.WriteLine("Obrigado por votar nessas eleições");
            Console.ReadKey();
            break;
        case "Zeca":
            totalVotosZeca++;
            break;
        case "Branco":
            totalVotosBranco++;
            break;

        case "FIM":
            Console.WriteLine("Programa encerrado");
            break;
        default:
            Console.WriteLine("Candidato inexistente");
            break;

    }
} while(voto !="FIM");

Console.WriteLine("Total de votos para o Zeca: ");
Console.WriteLine("Total de votos para o Joao: ");
Console.WriteLine("Total de votos para o Brancos: ");
