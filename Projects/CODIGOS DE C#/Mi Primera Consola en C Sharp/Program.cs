using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Mi_Primera_Consola_en_C_Sharp
{
    class Program
    {
        

        static void Main()
        {

            int i;    

            for(i = 1; i <= 10; i++)
            {
                if(i == 8)
                {
                    Console.WriteLine("se fue a pique el 8");
                    goto probando;
                }

                Console.WriteLine(i);

                probando:
                continue;
            }
         
            if(i == 8)
            {
                Console.WriteLine("ah po la vaina sigue");
            }


            Console.ReadKey(); 

        }

        
    }
}
