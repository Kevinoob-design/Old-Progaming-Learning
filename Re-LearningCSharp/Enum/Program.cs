using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    public enum AnimationDirection
    {
        Unknown = 0,
        Left = 1,
        Right = 2,
        Up = 3,
        Down = 4
    }

    class Program
    {
        static void Main(string[] args)
        {
        }

        public static void Animate(AnimationDirection direction)
        {
            switch (direction)
            {
                case AnimationDirection.Left:
                    Console.WriteLine("Animating left....");
                    break;
                case AnimationDirection.Right:
                    Console.WriteLine("Animating right....");
                    break;
                case AnimationDirection.Up:
                    Console.WriteLine("Animating up....");
                    break;
                case AnimationDirection.Down:
                    Console.WriteLine("Animating down....");
                    break;
                default:
                    Console.WriteLine("No animation set");
                    break;
            }
        }
    }
}
