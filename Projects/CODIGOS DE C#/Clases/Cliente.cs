using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class Cliente : Persona
    {
        //Atributos
        private string categoria;
        private string codigo;

        //Propiedades
        public string Categoria { get => categoria; set => categoria = value; }
        public string Codigo { get => codigo; set => codigo = value; }

        //Operacion
        public void GenerarCodigo()
        {
            this.Codigo = "C. " + this.Apellidos.Substring(0, 3) + "16";

        }
    }
}
