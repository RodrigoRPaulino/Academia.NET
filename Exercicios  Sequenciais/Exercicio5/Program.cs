// See https://aka.ms/new-console-template for more information


Console.WriteLine("Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel \n" +
    "(medido em Km / l), sendo que são conhecidos a distância total percorrida e o volume \n" +
    " de combustível consumido para percorrê - la(medido em l).");

double consumoMedio;
double distanciaTotal;
double volume;

Console.WriteLine("Informe a kilometragem percorrida:");
distanciaTotal = double.Parse(Console.ReadLine());



Console.WriteLine("Informe a quantidade de combustivel usada:");
volume = double.Parse(Console.ReadLine());

consumoMedio = distanciaTotal / volume;


Console.WriteLine("O consumo do seu veiculo e de: " +consumoMedio+ " Kilometos /l ");



/*260km 10 l gasolina
 * 260 /10  = 26kml*/


