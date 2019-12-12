using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Re_LearningCSharp
{
    class Program
    {
        byte    myByte      = 255;          //8bit
        char    myChar      = 'c';          //16bits
        short   myShort     = 65;           //16bits
        int     myInt       = 240000000;    //32bits
        uint    myUint      = 2400000000;   //23bits
        float   myFloat     = 1.23456789f;  //32bits
        double  myDouble    = 1.2345;       //32bits
        decimal myDecimal   = 1.4444m;      //128bits

        string myString     = "Hello world";

        bool myBool         = true;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
            Console.WriteLine("Hello bithces!");
            Console.ReadKey();

            ///Create a new instance of our number guesses class
            var Guesses = new NumberofGuesses();

            // Change the default value maximum number to 200
            Guesses.MaximumNumber = 100;

            // Ask the user to think of a number
            Guesses.InformUser();

            // Discover the number of the user is thinking of
            Guesses.DiscoverNumber();

            // Announce the results
            Guesses.AnnounceResults();
        }
    }
}