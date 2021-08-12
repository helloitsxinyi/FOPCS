using System;
namespace ExerciseE
{
    public class Q1b
    {
        public static void solution()
        {
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            int answer = 1;

            for (int i = 1; i <= num; i++)
            {
                answer *= i;
            }

            Console.WriteLine("The factorial of " + num + " is " + answer);
            ExerciseE.Main();
        }
    }
}

