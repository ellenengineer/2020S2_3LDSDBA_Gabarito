using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa que insira a senha via Console.ReadLine().
            //Se a senha estiver no vetor abaixo, diga (“acesso permitido!”)  
            //senão imprima(“acesso negado”). Pode usar while, for ou do while

            Console.WriteLine("Digite a senha: ");
            string senha = Console.ReadLine();

            Console.WriteLine(ValidarSenha(senha));
            Console.ReadLine();

        }

        static string ValidarSenha(string senha )
        {
            string[] vetor = { "teste", "password", "esqueci", "acertou", "123" };

            foreach (var item in vetor)
            {
                if (item == senha)
                {
                    return "acesso permitido!";
                }

            }
            return "acesso negado";

        }
    }
}
