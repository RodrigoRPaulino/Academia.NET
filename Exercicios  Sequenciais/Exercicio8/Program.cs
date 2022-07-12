// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit.\n" +
    " A fórmula da conversão é F = (9 * C + 160) / 5.");
/*parte 1 = receber informação em °C,  
parte 2 = converter a variavel, 
parte 3 aplicar formula, 
parte 4 exibir resultado */



Console.WriteLine("conversor de temperatura: ");

Console.Write("insira a temperatura em °C :");
double graus = double.Parse(Console.ReadLine());
double fahrenheit = (9 * graus + 160) / 5;
Console.WriteLine($" O Resultado da conversão em Fahrenheit é : {fahrenheit} Fahrenheit");









