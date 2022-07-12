// See https://aka.ms/new-console-template for more information
Console.WriteLine(" Escreva um algoritmo para ler o número de eleitores de um município,\n" +
    " o número de votos brancos, nulos e válidos.Calcule e escreva o percentual\n" +
    " que cada um  representa em relação ao total de eleitores.");



/// <summary>
/// numero de eleitores -> 100%
/// numero de votos brancos -> porcentagem de votos brancos
/// </summary>
int numeroEleitores;
int numeroVotosBrancos;
int numeroVotosNulos;
int numeroValidos;

int porcentangemVotosBrancos = numeroVotosBrancos * 100 / numeroEleitores;
int porcentangemVotosNulos;
int porcentangemVotosValidos;

Console.Write("Informe a quantidade de eleitores: ");
numeroEleitores = int.Parse(Console.ReadLine());

Console.Write("Informe a quantidade de votos em Branco");
numeroVotosBrancos = int.Parse(Console.ReadLine());

Console.Write("Informe o numero de votos nulos: ");
numeroVotosNulos = int.Parse(Console.ReadLine());



