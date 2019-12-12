using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    sealed class BaseHuman : LivingBeing
    {
        public string Name { get; private set; }
        public override string Sex { get; set; }
        public override string Raze { get; set; } = "Human";
        public override string color { get; set; } = "White";
        public override bool HasHair { get; set; } = true;

        override public void Eat()
        {
            Console.WriteLine($"{Name} is Eating");
        }
        override public void Run()
        {
            Console.WriteLine($"{Name} is Running");
        }
        override public void Sleep()
        {
            Console.WriteLine($"{Name} is Sleeping");
        }
        override public void Walk()
        {
            Console.WriteLine($"{Name} is Walking");
        }

        public BaseHuman(string name, string sex)
        {
           this.Name = name;
            this.Sex = sex;
        }
    }
}
