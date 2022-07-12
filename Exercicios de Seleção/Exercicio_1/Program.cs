// See https://aka.ms/new-console-template for more information
Console.WriteLine(" Faça um algoritmo para calcular e mostrar a área de um triângulo a partir dos valores da base e da altura lidos pelo teclado:\n" +
    " Área do triangulo = (base * altura) / 2; Teste se a base ou a altura digitada não foi igual a zero. ");

int baseTriangulo;
int alturaTriangulo;
int areaTriangulo;



Console.WriteLine("Digite o valor da base do triângulo :");
baseTriangulo = int.Parse(Console.ReadLine());
if (baseTriangulo >= 0)
{
    
    Console.WriteLine("Digite o valor da altura do triângulo ");
    alturaTriangulo = int.Parse(Console.ReadLine());

    areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;
    Console.WriteLine("A area do triangulo é:" + areaTriangulo);
}

else
{
    Console.WriteLine("o numero  nao deve ser menor que 0");

}










