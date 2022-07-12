// 5. Modifique o programa em VS anterior para aceitar votos nulos (qualquer nome diferente
// de FIM, JOAO, ZECA e BRANCO). Ao final, informe o nome do candidato vencedor, o número de
// votos nulos e o número de pessoas que votaram.

string voto; //Zeca, João, Branco
int totalVotosZeca = 0;
int totalVotosJoao = 0;
int totalVotosBrancos = 0;
int totalVotosNulos = 0;
int totalPessoas;
int vencedor;
do
{
    Console.Clear();
    Console.Write("Digite o nome do seu candidato, ou BRANCO, ou FIM para encerrar: ");
    voto = Console.ReadLine().ToUpper();

    switch (voto)
    {
        case "JOAO":
            totalVotosJoao++;
            break;
        case "ZECA":
            totalVotosZeca++;
            break;
        case "BRANCO":
            totalVotosBrancos++;
            break;
        case "FIM":
            Console.WriteLine($"Programa encerrado!");
            break;
        default:
            Console.WriteLine("Voto nulo!");
            totalVotosNulos++;
            break;
    }
    Console.WriteLine("Obrigado por votar nessas eleições!");
    Console.ReadKey();
} while (voto != "FIM");
if (totalVotosJoao > totalVotosZeca)
{
    Console.WriteLine($"O candidato vencedor foi o, João com {totalVotosJoao} votos.");
}
if (totalVotosJoao == totalVotosZeca)
{
    Console.WriteLine("Eleição empatada! aguardamos você no 2° turno.");
}
else 
{
    Console.WriteLine($"O candidato vencedor foi o, Zeca com {totalVotosZeca} votos.");
}
;

totalPessoas = totalVotosZeca + totalVotosJoao + totalVotosBrancos + totalVotosNulos;



Console.WriteLine($"O total de votos para o João: {totalVotosJoao}");
Console.WriteLine($"O total de votos para o Zeca: {totalVotosZeca}");
Console.WriteLine($"O total de votos em Branco: {totalVotosBrancos}");
Console.WriteLine($"O total de votos nulos: {totalVotosNulos}");
Console.WriteLine($"O total de eleitores que votaram é de : {totalPessoas} eleitores");