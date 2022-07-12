/*Crie uma classe para representar um item de cenário, com os atributos privados de:
    *descrição(string), 
    *data de criação(date - https://docs.microsoft.com/en-us/dotnet/api/system.datetime.date?view=net-6.0) e
    *altura(float).

Crie os métodos públicos necessários para sets e gets, o construtor básico e também um método para imprimir 
todos dados de um item de cenário. 
Por fim, crie um método para calcular a quanto tempo o item foi criado, além de um programa em C# para testar
a classe criada.*/
// instancia do namespace onde está  a classe

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercicio5
{
    public class Cenario
    {
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public float Altura { get; set; }

        // construtor com os parametros
        public Cenario(string descricao, DateTime datacriacao, float altura)
        {
            Descricao = descricao;
            DataCriacao = datacriacao;
            Altura = altura;
        }

    }


}