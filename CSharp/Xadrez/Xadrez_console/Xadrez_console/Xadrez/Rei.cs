using Xadrez_console.Tabuleiro;

namespace Xadrez_console.Xadrez
{
    class Rei : Peca
    {
        public Rei(Campo tab, Cor cor) : base(tab,cor)
        {

        }

        public override string ToString()
        {
            return "R";
        }

    }
}
