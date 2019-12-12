using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class MyIntList<T>
    {
        private List<T> mNumbers = new List<T>();

        public void addNumbers(T number)
        {
            mNumbers.Add(number);
        }

        public T GetNumber(int i)
        {
            return mNumbers[i];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new MyIntList<int>();
            numbers.addNumbers(1);
            numbers.addNumbers(2);
            numbers.addNumbers(3);
            numbers.addNumbers(4);
            numbers.addNumbers(5); 
            numbers.addNumbers(6);

            Console.WriteLine(numbers.GetNumber(3));
            Console.ReadKey();

        }
    }
}
