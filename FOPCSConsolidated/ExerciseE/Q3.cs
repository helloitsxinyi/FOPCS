using System;
namespace ExerciseE
{
    public class Q3
    {
        public static void solution()
        {
            // v elegant solution!
            Console.WriteLine("Please enter a number: ");
            int num = int.Parse(Console.ReadLine());
            int divisorCount = 0;

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    divisorCount += 1;
                }
            }

            if (divisorCount > 2)
            {
                Console.WriteLine("Your number is not a prime number.");
            }
            else
            {
                Console.WriteLine("Your number is a prime number!");
            }

            ExerciseE.Main();
        }
    }
}
