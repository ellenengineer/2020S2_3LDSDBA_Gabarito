using System;
using System.Collections.Generic;
using System.Text;

namespace OrientacaoObjetos
{
    public class PessoaFisica:clsPessoa
    {
        public int ID { get; set; }
        public string CPF { get; set; }
        public double Renda { get; set; }
        public string Sexo { get; set; }

        public List<clsEndereco> ListaEnderecos { get; set; }

        public PessoaFisica()
        {

        }
        public PessoaFisica(string _nome, DateTime _dataNascimento)
        {
            this.Nome = _nome;
            this.DtNascFund = _dataNascimento;
        }
    }
}
