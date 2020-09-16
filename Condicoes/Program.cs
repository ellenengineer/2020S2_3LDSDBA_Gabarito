using System;

namespace Condicoes
{
     enum TipoProduto
    {
        Casa =1,
        Eletronico = 2,
        Beleza =3

    }
    class Program
    {
        static void Main(string[] args)
        {
            ValorTotalCompra();
            CalculaValoresFrete();
            Console.ReadLine();
        }
        /// <summary>
        ///Fazer um programa que calcule o valor total da compra.
        ///Se o total dos valores dos produtos no carrinho for maior que $300, 00.
        ///Deixar o frete gratuito.Senão, incluir $15, 00 de frete
        /// </summary>
        static void ValorTotalCompra()
        {
            Console.WriteLine("Exercicio 1 ");
            Console.WriteLine("Digite o valor total da compra: ");
            double vlrTotal = Convert.ToDouble(Console.ReadLine());

            if (vlrTotal > 300.00)
            {
                Console.WriteLine("Frete gratuito!");
            }
            else
            {
                vlrTotal += 15.00;
                Console.WriteLine("Valor do frete: R$ 15,00. Total da compra : " + vlrTotal);
            }

            Console.WriteLine("-------------------------");
        }
        /// <summary>
        ///  Fazer um programa que calcula diferentes valores de frete, dependendo do tipo de produto.
        ///  Se o produto for casa, retornar $15, 00; se for  eletrônico  $20, 00 
        ///  se for cuidados e beleza,  $10, 00
        /// </summary>
        static void CalculaValoresFrete()
        {
            Console.WriteLine("Exercicio 2 ");
            Console.WriteLine("Digite o tipo de produto ");
            int intValorUsuario = Convert.ToInt32(Console.ReadLine());
            TipoProduto enumTipo = (TipoProduto)intValorUsuario;

            double valorFrete = 0.0;
            switch (enumTipo)
            {
                case TipoProduto.Casa:
                    valorFrete = 15.00;
                    break;
                case TipoProduto.Eletronico:
                    valorFrete = 20.00;
                    break;
                case TipoProduto.Beleza:
                    valorFrete = 10.00;
                    break;
                default:
                    valorFrete = 0.0;
                    break;
            }

            Console.WriteLine("O valor do frete é : " + valorFrete);
            Console.WriteLine("-------------------------");

        }
    }
}
