using System;
namespace ExerciseF
{
    public class Q1b
    {
        public static void solution()
        {
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

         
            while (num < 0)
            {
                Console.WriteLine("Error! Please input a number that is 0 or larger.");
                Console.WriteLine("Enter a number: ");
                num = int.Parse(Console.ReadLine());
            }

            if (num >= 0)
            {
                int answer = 1;

                for (int i = num; i >= 1; i--)
                {
                    answer *= i;
                }

                Console.WriteLine("The factorial of " + num + " is " + answer);
                ExerciseF.Main();
            }
        } 
    }
}

