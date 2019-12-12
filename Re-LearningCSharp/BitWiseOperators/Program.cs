using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitWiseOperators
{
    /// <summary>
    /// Binary
    /// </summary>
    /// <param name="args"></param>
    class Program
    {
        //
        //
        //Bitwise Operators

        //      And     & (Both)
        //      Or      | (Either)
        //      Xor     ^ (Exclusive or, different)
        //      Not     ~ (Invert)
        //
        static void Main(string[] args)
        {
            var a = 25;
            var b = 7;

            var result = a & b;
            var result1 = a | b;
            var result2 = a ^ b;
            var result3 = ~a;
            var result4 = ~b;

            Console.WriteLine($"Result = {result}");
            Console.WriteLine($"Result = {result1}");
            Console.WriteLine($"Result = {result2}");
            Console.WriteLine($"Result = {(byte)result3}");
            Console.WriteLine($"Result = {(byte)result4}");

            Console.WriteLine($"---------------");
            Console.WriteLine($"Result = {Convert.ToString(result, 2).PadLeft(8, '0')}");
            Console.WriteLine($"Result = {Convert.ToString(result1, 2).PadLeft(8, '0')}");
            Console.WriteLine($"Result = {Convert.ToString(result2, 2).PadLeft(8, '0')}");
            Console.WriteLine($"---------------");
            Console.WriteLine($"Result = {Convert.ToString(a, 2).PadLeft(8, '0')}");
            Console.WriteLine($"---------------");
            Console.WriteLine($"Result = {Convert.ToString(b, 2).PadLeft(8, '0')}");

            bool testValue = true;

            bool testValue2 = testValue ? true : false;

            Console.WriteLine(testValue2);

            Console.ReadKey();
        }
    }
}
