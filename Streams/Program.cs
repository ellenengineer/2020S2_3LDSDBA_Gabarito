using System;
using System.IO;
using System.Text;

namespace Streams
{
    class Program
    {

        static void Main(string[] args)
        {
            //Exercicio2();
            Exercicio3();
            Console.ReadLine();
        }

        /// <summary>
        /// 1 - Fazer um método que crie um diretório,
        /// caso ele não exista e retorne o nome do diretório criado e/ou existente
        /// </summary>
        static string Exercicio1()
        {
            string diretorio = @"C:\Fapen\";
            string diretorioRetorno = string.Empty;//equivalente a " "

            DirectoryInfo di = new DirectoryInfo(diretorio);
            try
            {
                if (!di.Exists)
                {

                    di.Create();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro ao gerenciar diretório: {0}", e.ToString());
            }
            finally
            {
                Console.WriteLine("Procedimento finalizado!");
            }
            return di.FullName;

        }
        /// <summary>
        ///  2 - Fazer um método que crie um arquivo chamado AulaFapen.txt,
        ///  dentro do diretório criado no ex 1. 
        ///  E escrever o seguinte conteúdo 
        ///  "Estamos utilizando a classe StreamWriter para escrever esse código! "                                             
        /// </summary>
        static void Exercicio2()
        {
            string arquivo = "AulaFapen.txt";
            string diretorio = Exercicio1();

            string caminho = diretorio + arquivo;

            try
            {
                using (StreamWriter writer = new StreamWriter(caminho))
                {
                    writer.WriteLine("Estamos utilizando a classe StreamWriter para escrever esse código! ");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message + "  " + ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("Finalizou a execução");
            }


        }
        /// <summary>
        /// 3 - Fazer um programa que leia o arquivo criado no exercício número 2 
        /// e jogue a frase escrita no arquivo em uma aplicação console   
        /// </summary>
        static void Exercicio3()
        {
            string arquivo = "AulaFapen.txt";
            string diretorio = Exercicio1();
            string caminho = diretorio + arquivo;

            StringBuilder sb = new StringBuilder();
            if (File.Exists(caminho))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(caminho))
                    {
                        String linha;
                        // Lê linha por linha até o final do arquivo
                        while ((linha = sr.ReadLine()) != null)
                        {
                            sb.AppendLine(linha);
                        }
                        Console.WriteLine(sb.ToString());
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("Operação finalizada!");
                }
            }
            else
            {
                Console.WriteLine(" O arquivo " + arquivo + " não foi localizado !");
            }
        }

    }
}
