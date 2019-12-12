using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Programa_De_Ficheros
{
    class Program
    {
        static void Main()
        {
            TextWriter Data;

            Data = new StreamWriter("Data.txt");

            string[] texto;

            texto = new string[5];

            texto[0] = Console.ReadLine();
            texto[1] = Console.ReadLine();
            texto[2] = Console.ReadLine();
            texto[3] = Console.ReadLine();
            texto[4] = Console.ReadLine();

            for(int i = 0; i <= 4; i++)
            {
                Data.WriteLine(texto[i]);
            }

            Data.Close();

            Console.Clear();

            Console.WriteLine("dique que se grabo la wea xD");

            Console.ReadKey();

            TextReader Lector;

            Lector = new StreamReader("Data.txt");

            Console.WriteLine(Lector.ReadToEnd());

            Lector.Close();

            Console.ReadKey();

            

        }
    }
}
