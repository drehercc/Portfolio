using System;
using System.Collections.Generic;
using System.Text;
using Xadrez_console.Tabuleiro;

namespace Xadrez_console
{
    class Tela
    {
        public static void ImprimirTabuleiro(Campo tab)
        {
            for (int i = 0; i < tab.Linhas; i++)
            {
                Console.WriteLine(8 - i +" ");
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if (tab.Peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        ImprimirPeca(tab.Peca(i, j));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");

        }
        public static void ImprimirPeca(Peca peca)
        {
            if(peca.Cor == Cor.Branco)
            {
                Console.Write(peca);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }
        
    }
}
