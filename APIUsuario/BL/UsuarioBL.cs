using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model;

namespace APIUsuario.BL
{
    public class UsuarioBL
    {

        public string IncluirUsuario(Usuario usuario)
        {
            List<Usuario> lstUsuario = new List<Usuario>();
            lstUsuario.Add(usuario);
            return "1";
        }

        public string InativarUsuario(Usuario usuario)
        {
            List<Usuario> lstUsuario = new List<Usuario>();
            lstUsuario.Remove(usuario);

            return "1";
        }
    }
}
