using System;
namespace ExerciseH
{
    public class Q3
    {
        public static void solution()
        {
            Console.WriteLine("pls enter integer");
            int integer = int.Parse(Console.ReadLine());
            int hexadecimal = ConvertToHexadecimal(integer);


        }

        static int ConvertToHexadecimal(int integer)
        {
            // div returns the quotient (int)
            int quotient = integer / 16;
            int remainder = integer % 16;

            int quotientHex = HexTableValue(quotient);
            int remainderHex = HexTableValue(remainder);

            int calculatedHexadecimal = quotientHex * 16 + remainderHex;

            return calculatedHexadecimal;
        }

        static int HexTableValue (int valueToCalculate)
        {
            int calculatedValue = 0;
            // hex conversion table
            switch (valueToCalculate)
            {
                case int i when (i <= 9):
                    calculatedValue = i;
                    break;
                case int i when (i >= 16 && i <= 25):
                    calculatedValue = i + 6;
                    break;
                    
            }
            return calculatedValue;

        }



    }
}

