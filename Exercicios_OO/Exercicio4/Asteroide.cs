/*Imagine um jogo com asteroides e uma nave de ataque, que deve destruir os asteróides que voam em todas as direções. 
 * Dessa forma, crie um programa em C# que represente
uma lista de asteroides que deveriam ser 'inseridos' no jogo. Para isso, faça uma classe que contenha os atributos 
(privados) posição x, posição y (do asteroide em
um plano cartesiano), tamanho do asteroide(1 a 10), velocidade do asteroide(1 a 5) e energia(1 a 5).Para esses atributos privados, gerar os métodos de acesso
(propriedades getter e setter). Além disso, implementar 3 construtores (sobrecarga): um vazio, outro passando todos
os parâmetros de um objeto tipo Asteroide, e um 
terceiro que constrói um asteroide com posição x e posição y. 
O programa principal (main) deve conter a lista de Asteroides, preenchida pelo usuário. Nesse programa principal, construir um método de classe que exiba todos os
asteróides da lista.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{   // criacao da classe 
    public  class Asteroide
    { //atributos
        private int PosicaoX { get; set; }
        private int PosicaoY { get; set; }
        private int TamanhoAsteroide { get; set; }
        private int VelocidadeAsteroide { get; set; }
        private int Energia { get; set; }
        // construtor vazio

        public Asteroide()
        {

        }
        public Asteroide(int posicaoX, int posicaoY)
        {
            PosicaoX = posicaoX;
            PosicaoY = posicaoY;

        }
        // construtor com os parametros 
        public Asteroide(int posicaoX, int posicaoY, int tamanho, int velocidade, int energia)
        {
            PosicaoX = posicaoX;
            PosicaoY = posicaoY;
            TamanhoAsteroide = tamanho;
            VelocidadeAsteroide = velocidade;
            Energia = energia;
        }

        // mostra a lista ao usuario
        // criamos o método mostrar asteroide 
        // recebemos a lista que ate entao esta vazia
        public static void MostrarAsteroides(List<Asteroide> listaAsteroides)
        {   // ele vai pegar cada asteroide na lista asteroides e mostrar na tela seus parametros.
            foreach (Asteroide asteroide in listaAsteroides)
            {
                Console.WriteLine($"PosicaoX:{asteroide.PosicaoX}");
                Console.WriteLine($"PosicaoY:{asteroide.PosicaoY}");
                Console.WriteLine($"Tamanho:{asteroide.TamanhoAsteroide}");
                Console.WriteLine($"Velocidade:{asteroide.VelocidadeAsteroide}");
                Console.WriteLine($"Energia:{asteroide.Energia}");
                Console.WriteLine("*********************************************");
            }
        }

    }
}