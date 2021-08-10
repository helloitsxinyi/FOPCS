using System;
namespace ExerciseC
{
    public class Q1
    {
        public static void solution()
        {       
            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();
            string gender;


            // can't do like the below: gender is always null as we refer to global scope during while condition.
            // gender is updated only in local NOT global scope during ReadLine, so while still sees gender as null.
            // reread about calling exceptions, if it goes out by 1 level, eventually to main level where it crashes
            // ?? but the variable should update!!

            //do
            //{
            //    Console.WriteLine("What is your gender? Enter M or F (case sensitive): ");
            //    gender = Console.ReadLine();                              
            //}
            //while (gender != "M" || gender != "F");

            do
            {
                Console.WriteLine("What is your gender? Enter M or F (case sensitive): ");
                gender = Console.ReadLine();

                if (gender == "M")
                {
                    Console.WriteLine("Good Morning Mr. {0}!", name);
                }
                else if (gender == "F")
                {
                    Console.WriteLine("Good Morning Ms. {0}!", name);
                }
                else return;
            }
            while (gender != "M" || gender != "F");

            //while (gender != "M" || gender != "F")
            //{
            //    Console.WriteLine("What is your gender? Enter M or F (case sensitive): ");
            //    gender = Console.ReadLine();
            //}

            //if (gender == "M")
            //{
            //    Console.WriteLine("Good Morning Mr. {0}!", name);
            //}
            //else 
            //{
            //    Console.WriteLine("Good Morning Ms. {0}!", name);
            //}
            }
        }
    }

