﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Crie uma classe para representar um objeto em um Plano Cartesiano. Todo objeto no plano cartesiano
tem como atributos 'x' e 'y'. Dessa forma, crie os getters e setter de 'x' e 'y', o construtor básico e
um método para exibir um objeto (x, y).
Por fim, crie um programa em C# que cadastre 'n' objetos em uma lista (List), um método de que exiba
os objetos da lista.*/


namespace Exercicio6
{
    internal class PlanoCartesiano
    {
        private int posicaoX;
        private int posicaoY;

        public PlanoCartesiano(int posicaoX, int posicaoY)
        {
            PosicaoX = posicaoX;
            PosicaoY = posicaoY;
        }

        public int PosicaoX { get; set; }
        public int PosicaoY { get; set; }
    }
}






















































