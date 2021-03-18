using System;
using tabuleiro;
using xadrez;

namespace xadrez_projeto.xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
        { 
        }
            public override string ToString()
        {

            return "R";
        }

    }
                
}
