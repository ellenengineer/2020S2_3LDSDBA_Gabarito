using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("fapen/Produto")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        /*
         * Criar uma WebAPI. Na pasta Controllers, criar um novo Controller, com leitura e gravação, renomeando para ProdutoController.cs. O Visual Studio vai criar um Controller contendo os métodos Default da WebAPI
Renomear a rota para fapen/Produto
Criar Um arquivo Produtos.txt contendo descrições: Fone de ouvido/nCelular/nImpressora/nNotebook, o “/n” representa quebra de linha, portanto, uma linha para cada produto. 
No método Get(), ler o arquivo criado no exercício 2 e retornar em json no browser. Para executar, chamar na url do browser, por exemplo,  
https://localhost:44376/fapen/Produto (ou outra porta que o IIS Exepress gerar)

         */
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {

            string arquivo = "Produtos.txt";
            string diretorio = @"C:\Fapen\";
            string caminho = diretorio + arquivo;

            List<string> lstProdutos = new List<string>();
            if (System.IO.File.Exists(caminho))
            {
                try
                {
                    using (System.IO.StreamReader sr = new System.IO.StreamReader(caminho))
                    {
                        String linha;
                        

                        // Lê linha por linha até o final do arquivo
                        while ((linha = sr.ReadLine()) != null)
                        {
                            lstProdutos.Add(linha);
                        }
                        return lstProdutos;
                    }
                }
                catch (Exception ex)
                {
                    return new string[] { ex.Message };
                }
            }
            else
            {
               return new string[] { "arquivo não localizado" };
            }
            
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
