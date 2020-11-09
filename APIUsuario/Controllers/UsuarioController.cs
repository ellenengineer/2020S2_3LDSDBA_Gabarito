using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model;
using APIUsuario.BL;


namespace APIUsuario.Controllers
{
    [Route("fapen/usuario")]
    public class UsuarioController : Controller
    {
        // GET: api/<Usuario>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Teste", "Teste2" };
        }

        [HttpGet("{login}")]
        [Route("logar/{login}")]
        public string LerLogin(string login)
        {
            Usuario usr = new Usuario(login);
            if (usr.Login == "ellen")
                return usr.Login + " : 1 ";
            else
                return usr.Login + " : 0 ";
        }

        // POST api/values
        [HttpPost]
        [Route("acessar")]
        public string Acessar([FromBody] Usuario value)
        {
            if (value != null)
            {
                if (value.Login == "ellen" && value.Senha == "123")
                {
                    return "OK";
                }
                else
                {
                    return "NOK";
                }
                
            }
            return "NOK - null";
        }


        // PUT api/<Usuario>/5
        [HttpPut]
        public ActionResult<IEnumerable<string>> Put( [FromBody] Usuario usu)
        {
            UsuarioBL usuBL = new UsuarioBL();
            return new string[] { usuBL.IncluirUsuario(usu) };

        }
        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<string>> Delete(int id)
        {
            if (id <= 0)
            {
                return new string[] { "Usuario inválido!" };
            }
            else
            {
                UsuarioBL usuBL = new UsuarioBL();
                Usuario usuario = new Usuario("ellen");
                usuario.ID = id;
                return new string[] { usuBL.InativarUsuario(usuario) };


            }
        }
    }
}
