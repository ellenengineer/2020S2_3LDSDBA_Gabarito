using System;
using System.Collections.Generic;
using System.Text;

namespace OrientacaoObjetos
{
    /// <summary>
    /// Exercicio 3 
    /// </summary>
    public abstract class clsPessoa
    {
        public string Nome { get; set; }
        public DateTime DtNascFund { get; set; }

        public string Email { get; set; }

        public clsEndereco Endereco { get; set; }

    }
}
