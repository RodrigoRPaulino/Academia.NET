﻿string opcao = "";
string nomeArquivo = "emails.dat"; //texto puro -> plain text
StreamWriter escritor = new StreamWriter(nomeArquivo); //abre o arquivo para escrita

do
{
    Console.Clear();
    Console.WriteLine("MENU");
    Console.WriteLine("1 - Cadastrar um email");
    Console.WriteLine("2 - Sair");

    Console.Write("Opção: ");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            //receber um email e gravar no arquivo
            try
            {
                string email;
                Console.Write("Digite email: ");
                email = Console.ReadLine().ToLower();
                escritor.WriteLine(email); //literalmente escreve no procurador e em memória
                escritor.Flush(); //garante depois de cada frase digitada que vá para o arquivo                
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro ao gravar o arquivo: " + e.Message);
            }
            break;
        case "2":
            Console.WriteLine("Obrigado por usar o sistema");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
    Console.Write("Pressione algo para continuar!");
    Console.ReadKey();
} while (opcao != "2");

escritor.Close(); //fecha o objeto que representa o arquivo