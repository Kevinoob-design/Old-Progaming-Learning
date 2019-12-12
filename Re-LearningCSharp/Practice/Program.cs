using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var Tony = new BaseHuman("Tony", "Male");

            Console.WriteLine($"The human is called {Tony.Name}");
            Console.WriteLine($"The human sex is called {Tony.Sex}");
            Tony.Run();
            Tony.Walk();
            Tony.Eat();
            Tony.Sleep();

            Console.ReadLine();
        }
    }
}
