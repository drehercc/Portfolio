using Xadrez_console.Tabuleiro;

namespace Xadrez_console.Xadrez
{
    class Peao : Peca
    {
        public Peao(Campo tab, Cor cor) : base(tab, cor)
        {

        }

        private bool ExisteInimigo(Posicao pos)
        {
            Peca p = Tab.Peca(pos);
            return p != null && p.Cor != Cor;
        }

        private bool Livre(Posicao pos)
        {
            return Tab.Peca(pos) == null;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];

            Posicao pos = new Posicao(0, 0);

            if(Cor == Cor.Branco)
            {
                pos.DefinirValores(pos.Linha - 1, pos.Coluna);
                if(Tab.PosicaoValida(pos) && Livre(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.DefinirValores(pos.Linha - 2, pos.Coluna);
                if (Tab.PosicaoValida(pos) && Livre(pos) && QteMovimento==0)
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.DefinirValores(pos.Linha - 1, pos.Coluna - 1);
                if (Tab.PosicaoValida(pos) && ExisteInimigo(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.DefinirValores(pos.Linha - 1, pos.Coluna + 1);
                if (Tab.PosicaoValida(pos) && ExisteInimigo(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
            }
            else
            {
                pos.DefinirValores(pos.Linha + 1, pos.Coluna);
                if (Tab.PosicaoValida(pos) && Livre(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.DefinirValores(pos.Linha + 2, pos.Coluna);
                if (Tab.PosicaoValida(pos) && Livre(pos) && QteMovimento == 0)
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.DefinirValores(pos.Linha + 1, pos.Coluna - 1);
                if (Tab.PosicaoValida(pos) && ExisteInimigo(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.DefinirValores(pos.Linha + 1, pos.Coluna + 1);
                if (Tab.PosicaoValida(pos) && ExisteInimigo(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
            }

            return mat;


        }

        public override string ToString()
        {
            return "P";
        }
        private bool PodeMover(Posicao pos)
        {
            Peca p = Tab.Peca(pos);
            return p == null || p.Cor != Cor;
        }

    }
}
