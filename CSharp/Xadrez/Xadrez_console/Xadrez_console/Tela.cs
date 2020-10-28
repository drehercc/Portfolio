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
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if (tab.Peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab.Peca(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
