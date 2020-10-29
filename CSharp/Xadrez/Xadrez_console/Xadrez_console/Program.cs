﻿using System;
using Xadrez_console.Tabuleiro;
using Xadrez_console.Xadrez;

namespace Xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Campo tabuleiro = new Campo(8, 8);

            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();
                
                while (!partida.Terminada)
                {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.Tab);
                    Console.WriteLine();

                    Console.Write("Origem: ");
                    Posicao origem = Tela.LerPosicaoXadrez().toPosicao();

                    bool[,] posicoesPossiveis = partida.Tab.Peca(origem).MovimentosPossiveis();
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.Tab, posicoesPossiveis);

                    Console.Write("Destino: ");
                    Posicao destino = Tela.LerPosicaoXadrez().toPosicao();
                    partida.ExecutaMovimento(origem, destino);
                }
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }


            Console.ReadLine();
            
        }
    }
}
