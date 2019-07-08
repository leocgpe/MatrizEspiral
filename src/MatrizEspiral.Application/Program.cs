using MatrizEspiral.Domain;
using System;
using System.Linq;

namespace MatrizEspiral.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            //midificação
            int qtdLinhas = 10;
            int qtdColunas = 8;
            int[] intArgs = args.Select(x => int.Parse(x)).ToArray();

            if(intArgs.Length == 2)
            {
                qtdLinhas = intArgs[0];
                qtdColunas = intArgs[1];
            }           

            var matriz = new Matriz(qtdLinhas, qtdColunas);
            var matrizEspiral = matriz.ProcessaMatrizEspiral();

            ImprimeMatriz(matrizEspiral);

            Console.ReadKey();
        }

        public static void ImprimeMatriz(int[,] matriz)
        {
            int qtdLinhas = matriz.GetLength(0);
            int qtdColunas = matriz.GetLength(1);
            int qtdMaxCaracteres = (qtdLinhas * qtdColunas).ToString().Length;

            for (int linha = 0; linha < qtdLinhas; linha++)
            {                
                for (int coluna = 0; coluna < qtdColunas; coluna++)
                {
                    Console.Write(matriz[linha, coluna].ToString().PadLeft(qtdMaxCaracteres, '0') + " ");
                }

                Console.WriteLine();
            }
        }

    }
}
