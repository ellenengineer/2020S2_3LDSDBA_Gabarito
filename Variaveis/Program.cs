using System;

namespace Variaveis
{
    public struct Retangulo
    {
        public string CalculaArea(double dblBase, double dblAltura)
        {
            double area = dblBase * dblAltura;

            return string.Concat("A área do retangulo é " , area," m2");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            imprimeAreaRetangulo();
            ConverterValores();
            DtaNasc();
            ValorTernario();

            Console.ReadLine();
        }

        /// <summary>
        /// Criar Programa onde imprime área do Retângulo.
        /// O calculo da área deverá ser calculado em uma struct e impresso em uma aplicação console
        /// </summary>
        static void imprimeAreaRetangulo()
        {
            Console.WriteLine("Ex 1: ");
            Retangulo stRetangulo = new Retangulo();
            Console.WriteLine("Digite a base do retangulo: ");
            double dblBase = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a altura do retangulo: ");
            double dblAltura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(stRetangulo.CalculaArea(dblBase,dblAltura));

            Console.WriteLine("-------------------------- ");
        }

        /// <summary>
        /// Criar Programa onde imprima valores convertidos de acordo com a tabela de conversões dada em aula
        /// </summary>
        static void ConverterValores()
        {
            Console.WriteLine("Ex 2: ");
            //implicita
            int numero1 = 10;
            double double1 = numero1;

            Console.WriteLine("Conversão implicita " +double1);

            //explicita
            double dbl1 = 10.23;
            int number1 = (int)dbl1;
            Console.WriteLine("Conversão explicita " +number1);

            //classes auxiliares
            int num1 = 0;
            num1 = Convert.ToInt32("356");
            Console.WriteLine("Conversão por classes auxiliares " + num1);

            //boxing
            int num = 123;
            object obj = num;
            Console.WriteLine("Boxing : " + obj);

            //unboxing
            int numero = 123;
            object obj1 = numero;
            int num2;
            num2 = (int)obj1;
            Console.WriteLine("unboxing: " + num2);


            //var
            var varivael = "teste";
            Console.WriteLine("Var : " + varivael);

            Console.WriteLine("-------------------------- ");
        }

        /// <summary>
        /// Criar Programa onde imprima a data do seu nascimento, 
        /// com todas as conversões strings passadas em aula
        /// </summary>
        static void DtaNasc()
        {
            Console.WriteLine("Ex 3: ");
            DateTime minhaDtNasc = new DateTime(1986, 01, 28);
            Console.WriteLine("Short Date: " + minhaDtNasc.ToString("d"));
            Console.WriteLine("Long Date: " + minhaDtNasc.ToString("D"));
            Console.WriteLine("Full Date: " + minhaDtNasc.ToString("F"));
            Console.WriteLine("Year/Month: " + minhaDtNasc.ToString("y"));
            Console.WriteLine("mont/ day year: " + minhaDtNasc.ToString("MM '/' dd yyyy"));
            Console.WriteLine("day.month.year: " + minhaDtNasc.ToString("dd.MM.yyyy"));
            Console.WriteLine("day.month.year hh:mm: " + minhaDtNasc.ToString("dd.MM.yyyy HH:mm"));
            Console.WriteLine("Dia da semana e hora: " + minhaDtNasc.ToString("dddd @ hh: mm tt", System.Globalization.CultureInfo.InvariantCulture));
            Console.WriteLine("-------------------------- ");
        }
        /// <summary>
        /// Crie um programa onde valida dois números com operador ternário, 
        /// se o número a for maior que o b, imprmir “a maior que o b.senão, imprimir b maior que a
        /// </summary>
        static void ValorTernario()
        {
            Console.WriteLine("Ex 4: ");
            Console.WriteLine("Digite o Valor de A: ");
            int valorA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o Valor de B: ");
            int valorB = Convert.ToInt32(Console.ReadLine()); 

            var retorno = valorA > valorB ? "A maior que B" : "B maior que A";
            Console.WriteLine(retorno);

            Console.WriteLine("-------------------------- ");

        }

    }
}
