using System;
using System.Linq;

namespace ExerciseH
{
    public class Q3
    {
        public static void solution()
        {
            Console.WriteLine("Number \t Hexadecimal");

            for (int i = 1; i <= 100; i++)
            {
                string hexadecimal = ConvertToHexadecimal(i);
                Console.WriteLine($"{i} \t {hexadecimal}");
            }                   

        }

        static string ConvertToHexadecimal(int integer)
        {
            string hexadecimal = "";

            if (integer == 0)
            {
                hexadecimal += Convert.ToString(0);
            }

            while (integer != 0)
            {
                int remainder = integer % 16;

                switch (remainder)
                {
                    case 10:
                        hexadecimal += "A";
                        break;
                    case 11:
                        hexadecimal += "B";
                        break;
                    case 12:
                        hexadecimal += "C";
                        break;
                    case 13:
                        hexadecimal += "D";
                        break;
                    case 14:
                        hexadecimal += "E";
                        break;
                    case 15:
                        hexadecimal += "F";
                        break;
                    default:
                        hexadecimal += Convert.ToString(remainder);
                        break;
                }
                
                integer /= 16;

            }
            // simpler using built in method.
            //return new string(hexadecimal.ToCharArray().Reverse().ToArray());
            string reversedHexadecimal = "";

            for (int i = hexadecimal.Length - 1; i >= 0; i--)
            {
                reversedHexadecimal += hexadecimal[i];
            }

            return reversedHexadecimal;
        }         
    }
}

