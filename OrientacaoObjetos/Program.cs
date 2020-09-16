using System;
using System.Collections.Generic;

namespace OrientacaoObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  1 - Criar Interface chamada IEndereco, onde deverá conter o seguinte método: string Consultar(); 

                2 - Fazer uma classe não abstrata chamada Endereco, que implemente a interface IEndereco. a classe contera os seguintes campos: Tipo Endereco, ID,Cidade, Logradouro, Bairro e complemento;

                3 - Fazer uma classe  abstrata chamada Pessoa, com atributos: Nome,dtNascFund, e-mail, endereço(tipo clsEndereco, do ex 1);

                4 - Fazer duas classes não abstrata chamadas ClientePF e ClientePJ que herdam as características da classe Pessoa e que contenham os  atributos: 
                *ClientePF - ID,CPF, renda e sexo; 
                *ClientePJ – ID, CNPJ,lucro e tipoEmpresa

                5 - Dentro da aplicação console, criar uma pessoa fisica e mostrar o endereço completo de onde ela mora
*/

            clsPessoa objPessoa = new PessoaFisica();
            objPessoa.Nome = "Ellen";
            objPessoa.Endereco = new clsEndereco();
            objPessoa.Endereco.Logradouro = "Logradouro1";
            objPessoa.Endereco.Complemento = "apto 2";
            objPessoa.Endereco.Bairro = "Centro";
            objPessoa.Endereco.Cidade = "São Bernardo do Campo";

            Console.WriteLine(objPessoa.Nome + " mora em " + objPessoa.Endereco.Consultar());

            /* //Criar uma Coleção de Endereços vinculados a Pessoa
             //, usando uma das classes vista em sala de aula
             //Criar uma coleção de Pessoas usando Dictionary<key, value> ou List<T>

             PessoaFisica objPF = new PessoaFisica();
             objPF.CPF = "9999999999";
             objPF.ID = 1;
             objPF.Nome = "Ellen";
             objPF.Endereco = new clsEndereco();
             objPF.Endereco.ID = 1;
             objPF.Endereco.Cidade = "São Bernardo";
             objPF.Endereco.Tipo = TipoEndereco.Residencial;

             objPF.ListaEnderecos = new System.Collections.Generic.List<clsEndereco>();
             objPF.ListaEnderecos.Add(objPF.Endereco);

             objPF.Endereco = new clsEndereco();
             objPF.Endereco.ID = 2;
             objPF.Endereco.Cidade = "Santo Andre";
             objPF.Endereco.Tipo = TipoEndereco.Comercial;

             objPF.ListaEnderecos.Add(objPF.Endereco);

             Console.WriteLine(objPF.Nome + " tem os seguintes enderecos: ");
             foreach (var end in objPF.ListaEnderecos)
             {
                 Console.WriteLine(end.Cidade);
             }

             List<PessoaFisica> listaPEssoas = new List<PessoaFisica>();
             listaPEssoas.Add(objPF);

             PessoaFisica objPF1 = new PessoaFisica();
             objPF1.CPF = "111111111";
             objPF1.ID = 2;
             objPF1.Nome = "Fulano";

             listaPEssoas.Add(objPF1);

             foreach (var pessoa in listaPEssoas)
             {
                 Console.WriteLine(pessoa.Nome + " CPF : " + pessoa.CPF);
             }*/

            Console.ReadLine();

        }
    }
}
