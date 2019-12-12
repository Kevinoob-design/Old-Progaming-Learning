using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class Persona
    {
        //Atributos
        private string apellidos;
        private string nombres;
        private string documento;
        private string tipo;

        //Propiedades
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Documento { get => documento; set => documento = value; }
        public string Tipo { get => tipo; set => tipo = value; }
    }
}
