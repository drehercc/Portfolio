using Xadrez_console.Tabuleiro;

namespace Xadrez_console.Xadrez
{
    class Torre : Peca
    {
        public Torre(Campo tab, Cor cor) : base(tab, cor)
        {

        }

        public override string ToString()
        {
            return "T";
        }

    }
}
