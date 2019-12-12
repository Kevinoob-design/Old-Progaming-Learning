using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mi_Primer_Objeto
{
    class Program
    {
        static void Main(string[] args)
        {

            Probando impresion = new Probando();

            impresion.ejecucion();

            Console.ReadKey();
        }
    }

    class Probando
    {
        public int primera = 30;
        public int segunda = 20;
        public int tercera;

        public void ejecucion()
        {
            ejecucion2();

        }

        private void ejecucion2()
        {
            tercera = primera + segunda;
            Console.WriteLine(tercera);
        }

        public void aver()
        {
            Console.WriteLine("se imprimio tooo");

        }
    }
}
