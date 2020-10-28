using System;
using Xadrez_console.Tabuleiro;
using Xadrez_console.Xadrez;

namespace Xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Campo tabuleiro = new Campo(8, 8);

            tabuleiro.ColocarPeca(new Torre(tabuleiro,Cor.Preto),new Posicao(0,0));
            tabuleiro.ColocarPeca(new Torre(tabuleiro,Cor.Preto), new Posicao(1, 3));
            tabuleiro.ColocarPeca(new Rei(tabuleiro, Cor.Preto), new Posicao(2, 4));
            Tela.ImprimirTabuleiro(tabuleiro);

            Console.ReadLine();
            
        }
    }
}
