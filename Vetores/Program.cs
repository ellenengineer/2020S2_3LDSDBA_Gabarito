using System;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa que retorne uma matriz(linha x coluna) de 2 colunas e 3 linhas 
            //contendo nome dos produtos:

            string[,] posicao = new string[3, 2];
            posicao[0, 0] = "celular samsung";
            posicao[1, 0] = "celular xiaomi";
            posicao[2, 0] = "celular motorola";

            posicao[0, 1] = "fone bluetooth";
            posicao[1, 1] = "mouse razer";
            posicao[2, 1] = "chromecast";

            //desconsiderar as demais posicoes


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                    Console.WriteLine(posicao[i, j]);
            }

        }
    }
}
