using System;
using System.Collections.Generic;
using System.Globalization;
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

        public void DecrementarQteMovimentos()
        {
            QteMovimento--;
        }

        public bool ExisteMovimentosPossiveis()
        {
            bool[,] mat = MovimentosPossiveis();

            for(int i = 0; i < Tab.Linhas; i++)
            {
                for(int j = 0; j < Tab.Colunas; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool PodeMoverPara(Posicao pos)
        {
            return MovimentosPossiveis()[pos.Linha, pos.Coluna];
        }

        public abstract bool[,] MovimentosPossiveis();
        
    }
}
