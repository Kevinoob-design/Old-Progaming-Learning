using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SinglePage.Models
{
    public class UsuariosData
    {
        public IEnumerable<Usuario> GetUsuario()
        {
            List<Usuario> lista = new List<Usuario>();

            for(int i = 1; i <= 200; i++)
            {
                Usuario oUsuario = new Usuario
                {
                    Id = 1000000 + i,
                    Name = "Nombre " + i,
                    Edad = DateTime.Now.Year - DateTime.Now.AddMonths(-i).Year
                };

                lista.Add(oUsuario);
            }

            return lista;
        }
    }
}