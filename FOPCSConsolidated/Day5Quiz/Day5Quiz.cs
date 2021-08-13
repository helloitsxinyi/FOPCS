using System;

namespace Day5Quiz
{
        class Day5Quiz
    {
        static void Main()
        {
            int[,] theArray = new int[,]
            {
            {5,3},{2,9},{2,9},
            {5,1},{7,1},{8,3},
            {0,3},{2,2},{9,7}
            };

            int count = 0;

            Console.Write("Please enter a number (0-9): ");
            int input = Convert.ToInt32(Console.ReadLine());

            //Your code here
            //try
            //{
                for (int i = 0; i < theArray.GetLength(0); i++)
                {
                    for (int j = 0; j < theArray.GetLength(1); j++)
                    {
                        if (theArray[i, j] == input)
                        {
                            count += 1;
                        }
                    }
                }

                if (count >= 1)
                {
                    Console.WriteLine($"The number of {input} is {count}");
                }
                else
                {
                    Console.WriteLine($"There is no {input} in the array.");
                }

            //}
            //***fix catch to display the error message***
            //catch (FormatException)
            //{                
            //    Console.WriteLine("Invalid input, please input only a number from 0-9!");
            //    Main();
            //}


        }
    }
}
