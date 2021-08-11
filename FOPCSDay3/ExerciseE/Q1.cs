using System;
namespace ExerciseE
{
    public class Q1
    {
        public static void solution()
        {       
            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();
            string gender;                         

            do
            {
                Console.WriteLine("What is your gender? Enter M or F (case sensitive): ");
                gender = Console.ReadLine();

                // important in order to exit the loop and move on to next part of code.
                if (gender == "M" || gender == "F")
                {
                    break;
                }
            }
            // if gender == M,
            // gender != M -> false
            // gender != F -> true
            // gender != M || gender !=F -> true, so continue executing do code block.
            // stops if while is false.
            while (gender != "M" || gender != "F");

            if (gender == "M")
            {
                Console.WriteLine("Good Morning Mr. {0}!", name);
            }
            else
            {
                Console.WriteLine("Good Morning Ms. {0}!", name);
            }
        }
    }
}

