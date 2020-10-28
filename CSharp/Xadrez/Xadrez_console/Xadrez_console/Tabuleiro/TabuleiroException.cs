using System;
using System.Collections.Generic;
using System.Text;

namespace Xadrez_console.Tabuleiro
{
    class TabuleiroException : Exception
    {
        public TabuleiroException(string msg) : base(msg)
        {

        }
    }
}
