using System;

namespace Quiz
{
    class ConvertCmToIn
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the length in cm: ");
            double lengthInCm = double.Parse(Console.ReadLine());
            double lengthInInch = lengthInCm / 2.54;
            Console.WriteLine("{0:0.000}", lengthInInch);


        }
    }
}
