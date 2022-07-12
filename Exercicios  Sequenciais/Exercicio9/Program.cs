// See https://aka.ms/new-console-template for more information
Console.WriteLine(" Uma loja vende seus produtos no sistema de entrada mais duas prestações, sendo a entrada maior do que ou igual às duas prestações, que devem ser iguais, inteiras /n" +
    " e as maiores possíveis. Por exemplo,/n" +
    " se o valor da mercadoria for R$ 270,00, a entrada e as duas prestações são iguais a R$ 90,00;se o valor da  /n" +
    "mercadoria for R$ 302,75 a entrada é de R$ 102,75 e as duas prestações são iguais a R$ 100,00./n" +
    "Escreva um programa em C# e no Visual Studio que receba o valor da mercadoria e forneça o valor da entrada /n" +
    " e das duas prestações, de acordo com as regras acima. Observe que uma justificativa para a adoção desta regra é que ela facilita a confecção e o conseqüente pagamento dos boletos das duas prestações.");
 


Console.WriteLine($"Digite o valor total da compra: ");


double valorTotal =double.Parse(Console.ReadLine()); // compra de 300 reais
double valorMinimoEntrada = valorTotal / 3; // valor minimo
double valorDeEntrada = 0;
double parcelas = 0;
bool repetir = true; //bool e uma variavel que so pode armazenar dentro dela true ou false

Console.WriteLine($"Digite o valor da entrada: {valorMinimoEntrada}");

while (repetir) //while = enquanto
{
    valorDeEntrada = double.Parse(Console.ReadLine());


    if (valorDeEntrada >= valorMinimoEntrada)
    {   //calcular o valor das 2 pacelas restantes
         parcelas = (valorTotal - valorDeEntrada)/2;
        repetir = false;
    }
    else
    {
        Console.WriteLine($"Valor informado e inferior ao minimo desta compra\n" +
            $" O valor minimo é: {valorMinimoEntrada}");
    }


}
Console.WriteLine($" O valor total da compra é: {valorTotal}");
Console.WriteLine($"O valor de entrada é de R${valorDeEntrada}");
Console.WriteLine($"O valor das percelas (2) é:{parcelas}");
       
