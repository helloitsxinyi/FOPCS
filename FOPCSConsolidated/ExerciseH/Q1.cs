using System;
namespace ExerciseH
{
    public class Q1
    {
        public static void solution()
        {
            Console.Write("Enter an integer:");
            string message = Console.ReadLine();
            ReadInteger(message);
            ExerciseH.Main();            
        }

        public static int ReadInteger(string message)
        {
            int parsed = 0;
            try
            {
                parsed = int.Parse(message);
                Console.WriteLine($"Your integer is {parsed}!");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid input! Please enter an integer: ");
                message = Console.ReadLine();
                ReadInteger(message);
            }

            return parsed;
        }
    }
}

