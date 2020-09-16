using System;
using System.Collections.Generic;
using System.Text;

namespace OrientacaoObjetos
{
   public enum TipoEndereco
    {
        Residencial,
        Comercial,
        Outros
    }
    public class clsEndereco : IEndereco
    {
        public int ID { get; set; }
        public string Cidade { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }

        public TipoEndereco Tipo { get; set; }

        public string Consultar()
        {
            return string.Concat(Logradouro, " " , Complemento, " " , Bairro, " ", Cidade);
        }
    }
}
