

namespace tabuleiro
{
    abstract class Peca
    {

        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; private set; }

        public Peca( Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.qteMovimentos = 0;
            //começa com 0 pois a peça no inicio do jogo nao tem movimentos
           
        }

        public void incementarQteMovimentos()
        {
            qteMovimentos++;
        }

        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = movimentosPossiveis();
            for(int i = 0; i < tab.linhas; i++)
            {
                for(int j = 0; j < tab.colunas; j++)
                {
                    if(mat[i, j])
                    {
                        return true;
                    }

                }
            }
            return false;
        }

        public abstract bool[,] movimentosPossiveis();
      

      


    }
}
