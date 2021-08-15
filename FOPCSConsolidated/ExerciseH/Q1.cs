using System;
namespace ExerciseH
{
    public class Q1
    {
        public static void solution()
        {
            try
            {
                Console.Write("Enter an integer:");
                string message = Console.ReadLine();
                ReadInteger(message);

            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid input! Please enter an integer: ");
                message = Console.ReadLine();
            }
          

            ExerciseH.Main();
            
        } 
    }
}

