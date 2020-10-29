using System;
using System.Collections.Generic;
using System.Text;

namespace Xadrez_console.Tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimento { get; protected set; }
        public Campo Tab { get; protected set; }

        public Peca(Campo tab, Cor cor)
        {
            Posicao = null;
            Cor = cor;
            Tab = tab;
            QteMovimento = 0;
        }

        public void IncrementarQteMovimentos()
        {
            QteMovimento++;
        }

        public abstract bool[,] MovimentosPossiveis();
        
    }
}
