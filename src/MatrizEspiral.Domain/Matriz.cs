namespace MatrizEspiral.Domain
{
    public class Matriz
    {
        private readonly int qtdLinhasOriginal;
        private readonly int qtdColunasOriginal;
        private readonly int qtdCelulasTotal;
        private int qtdLinhasProcessamento;
        private int qtdColunasProcessamento;
        private int linhaAtual;
        private int colunaAtual;
        private int qtdCelulasProcessadas;
        private int valor;
        private int[,] matrizDefinitiva;

        public Matriz(int qtdLinhas, int qtdColunas)
        {
            this.qtdLinhasOriginal = qtdLinhas;
            this.qtdColunasOriginal = qtdColunas;
            this.qtdCelulasTotal = qtdLinhas * qtdColunas;
            this.qtdLinhasProcessamento = qtdLinhas;
            this.qtdColunasProcessamento = qtdColunas;
            this.linhaAtual = 1;
            this.colunaAtual = 0;
            this.qtdCelulasProcessadas = 0;
            this.valor = 0;

            this.matrizDefinitiva = new int[qtdLinhas, qtdColunas];
        }

        public int[,] ProcessaMatrizEspiral()
        {
            AndaParaDireita();
            AndaParaBaixo();
            ReduzLinhasEColunas();

            AndaParaEsquerda();
            AndaParaCima();
            ReduzLinhasEColunas();

            if (!AtingiuLimite())
                ProcessaMatrizEspiral();

            return matrizDefinitiva;
        }

        private void AndaParaCima()
        {
            for (int i = 1; i < qtdLinhasProcessamento && !AtingiuLimite(); i++)
            {
                linhaAtual--;
                AdicionaValor();
            }
        }

        private void AndaParaEsquerda()
        {
            for (int i = 1; i <= qtdColunasProcessamento && !AtingiuLimite(); i++)
            {
                colunaAtual--;
                AdicionaValor();
            }
        }

        private void AndaParaBaixo()
        {
            for (int i = 1; i < qtdLinhasProcessamento && !AtingiuLimite(); i++)
            {
                linhaAtual++;
                AdicionaValor();
            }
        }

        private void AndaParaDireita()
        {
            for (int i = 1; i <= qtdColunasProcessamento && !AtingiuLimite(); i++)
            {
                colunaAtual++;
                AdicionaValor();
            }
        }

        private void ReduzLinhasEColunas()
        {
            qtdLinhasProcessamento--;
            qtdColunasProcessamento--;
        }

        private void AdicionaValor()
        {
            valor++;
            qtdCelulasProcessadas++;
            matrizDefinitiva[linhaAtual - 1, colunaAtual - 1] = valor;
        }

        private bool AtingiuLimite() => qtdCelulasProcessadas >= qtdCelulasTotal;
    }
}