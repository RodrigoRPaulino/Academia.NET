// See https://aka.ms/new-console-template for more information
Console.WriteLine(" Faça um programa em VS que solicite um número inteiro positivo ao usuário, validando a entrada de dados\n" +
    " (informando se ele estiver errado e repetindo a solicitação até que esteja correto).\n" +
    "Após o programa em VS deve informar todos os números pares existentes\n" +
    " entre 1 e o número fornecido pelo usuário.");

/*Modificar o programa em VS anterior para que ao final ele pergunte ao usuário se ele deseja 
informar um outro número. Caso positivo, o programa em VS deve ser repetido.*/




int numero;
char novoNumero;
//enquanto essa condição for verdade
while (true)
{ //faça
    do
    {
        Console.WriteLine("Digite um número inteiro positivo: ");
        numero = int.Parse(Console.ReadLine());
    // se variavel menor que 0
        if (numero < 0)
        {
            Console.WriteLine("O número digitado não é positivo!");
        }
    //enquanto...
    } while (numero < 0);
    Console.WriteLine($"O número digitado foi: {numero}.");
    Console.WriteLine($"Os números inteiros pares entre 1 e {numero} são: ");
 // para
    for (int i = 1; i < numero; i++)
    {// se
        if (i % 2 == 0)
        {
            Console.WriteLine(i + " ");
        }
    }
    Console.WriteLine("Deseja informar um novo número (s/n)? ");
    novoNumero = char.Parse(Console.ReadLine());
//  se            igual   ou
    if (novoNumero == 'n' || novoNumero == 'N')
    { // para o laço
        Console.WriteLine("Obrigado por ultilizar nosso programa!");
        break;
    }
}










