using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_y_Objetos_CSharp
{
    public class Perro
    {
        //Atributos
        private string nombre;
        private string raza;
        private string altura;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Raza { get => raza; set => raza = value; }
        public string Altura { get => altura; set => altura = value + "cm"; }

        //Operaciones
        public string comer(string carne)
        {
            return this.Nombre + " mide " + this.Altura + " y va a comer " + carne;
        }

        public void dormir()
        {

        }

        public void ladrar()
        {

        }

        //Constructor

        public Perro()
        {

        }

        public Perro(String nombre, String raza, String altura)
        {
            this.Nombre = nombre;
            this.Raza = raza;
            this.Altura = altura;
        }

        
    }
}
