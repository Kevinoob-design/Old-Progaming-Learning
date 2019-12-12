using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    abstract class LivingBeing : Actions, Characteristics
    {
        abstract public string Sex { get; set; }
        abstract public string Raze { get; set ; }
        abstract public string color { get; set; }
        abstract public bool HasHair { get; set; }

        virtual public void Eat()
        {
            Console.WriteLine("Eating");
        }
        virtual public void Run()
        {
            Console.WriteLine("Running");
        }
        virtual public void Sleep()
        {
            Console.WriteLine("Sleeping");
        }
        virtual public void Walk()
        {
            Console.WriteLine("Walking");
        }
    }
}
