using System;
using System.Collections;
using OrientacaoObjetos;

namespace Exception
{
    class Program
    {
        /// <summary>
        /// Fazer um programa que altera o ArrayList mostrado na aula anterior,
        /// incluindo um tipo string ao invés de clsPessoa. Ao percorrer o arraylist
        /// , se o tipo não for clsPessoa, mostrar mensagem: “Tipo inserido no ArrayList inválido”

        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            TesteArrayList();
        }

        static void TesteArrayList()
        {
            ArrayList alPessoaFisica = new ArrayList();
            alPessoaFisica.Add(new PessoaFisica("Fulano", new DateTime(1980, 05, 30)));
            alPessoaFisica.Add(new PessoaFisica("Beltrano", new DateTime(1990, 04, 10)));
            alPessoaFisica.Add(new PessoaFisica("Ciclano", new DateTime(1995, 02, 25)));
            alPessoaFisica.Add(new PessoaFisica("Ellen", new DateTime(1986, 01, 28)));
            alPessoaFisica.Add(new PessoaFisica("Chun Li", new DateTime(2014, 02, 03)));
            alPessoaFisica.Add(new PessoaFisica("Sindel", new DateTime(2014, 04, 07)));
            alPessoaFisica.Add("Teste");

            // Imprime valores do ArrayList.
            Console.WriteLine("Array List Pessoa Fisica");
            Console.WriteLine("    Total Itens:    {0}", alPessoaFisica.Count);
            Console.WriteLine("    Capacidade: {0}", alPessoaFisica.Capacity);
            Console.Write("    \nValores com object:");
            foreach (Object obj in alPessoaFisica)
            {
                try
                {
                    Console.Write("   {0}", ((PessoaFisica)obj).Nome);
                }
                catch
                {
                    Console.WriteLine("\nTipo {0} inserido no ArrayList inválido", obj);
                }
                finally
                {
                    Console.WriteLine("Execução finalizada!");
                }

            }

            Console.Write("    \nValores com clsPessoaFisica:");

            try
            {
                foreach (PessoaFisica objPF in alPessoaFisica)
                    Console.Write("   {0}", objPF.Nome);
            }
            catch
            {
                Console.WriteLine("\nArrayList contem um tipo inválido");
            }

            Console.WriteLine("Com var...");
            foreach (var item in alPessoaFisica)
            {
                try
                {
                    Console.WriteLine(" {0}", ((PessoaFisica)item).Nome);
                }
                catch
                {

                    Console.WriteLine("\nTipo {0} inserido no ArrayList inválido", item);
                }

            }

        }
    }
}
