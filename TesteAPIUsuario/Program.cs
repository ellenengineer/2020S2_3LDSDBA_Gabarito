using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using Model;
using System.Net.Http.Headers;
using System.Net.Http.Formatting;
using Newtonsoft.Json;


namespace TesteAPIUsuario
{
    class Program
    {
        static void Main(string[] args)
        {
            Get();
            Post();
            Put();
            Delete();
            Console.ReadLine();
        }
        private static void Get()
        {/*//Criando uma requisição*/
            var request = (HttpWebRequest)WebRequest.Create("http://localhost:8081/fapen/usuario/logar/ellen");
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            Console.WriteLine(responseString);
        }

        private static void Post()
        {
            using (var client = new HttpClient())
            {
                Usuario usuario = new Usuario { ID = 1, Login = "ellen", Senha = "123" };
                client.BaseAddress = new Uri("https://localhost:44363/fapen/usuario/acessar");
                //client.BaseAddress = new Uri("http://localhost:8081/fapen/usuario/acessar");
                var response = client.PostAsJsonAsync("acessar/", usuario).Result;
                if (response.IsSuccessStatusCode)
                {
                    Console.Write("Success");
                }
                else
                    Console.Write("Error");
            }

        }

        static void Delete()
        {
            using (var client = new HttpClient())
            {
                string usuarioID = "1";
                client.BaseAddress = new Uri("https://localhost:44363/fapen/");
                var response = client.DeleteAsync("usuario/" + usuarioID).Result;
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine(response.ToString());
                }
                else
                    Console.WriteLine("Erro: " + response.ToString());
            }
        }

        static void Put()
        {
            using (var client = new HttpClient())
            {
                Usuario usuario = new Usuario { ID = 1, Login = "Fulano", Senha = "456" };
                //client.BaseAddress = new Uri("http://localhost:8081/fapen/");
                client.BaseAddress = new Uri("https://localhost:44363/fapen/");
                var response = client.PutAsJsonAsync("usuario", usuario).Result;
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Sucesso ! " + response.ToString());
                }
                else
                    Console.Write("Erro ao inserir usuario: " + response.ToString());
            }
        }

    }
}
