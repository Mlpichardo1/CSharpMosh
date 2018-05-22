using System;

namespace Mosh
{
    class Program
    {
        static void Main(string[] args)
        {
            // all data types can be replaced with Var
            byte number = 2; // byte has to be explicitly declared to use it 
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Manny";
            bool isWorking = false;

            Console.WriteLine(number);
            System.Console.WriteLine(count);
            System.Console.WriteLine(totalPrice);
            System.Console.WriteLine(character);
            System.Console.WriteLine(firstName);
            System.Console.WriteLine(isWorking);

            /////////////////////////////
            // Place holder
            System.Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            System.Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

        }
    }
}
