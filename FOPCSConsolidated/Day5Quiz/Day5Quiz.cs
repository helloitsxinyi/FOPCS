using System;

namespace Day5Quiz
{
        class Day5Quiz
    {
        static void Main(string[] args)
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
            for (int i = 0; i < theArray.GetLength(0); i++) { 
                for (int j = 0; j < theArray.GetLength(1); j++)
                {
                    if (theArray[i,j] == input)
                    {
                        count += 1;
                    }
                }
            }

            if (count >= 1)
            {
                Console.WriteLine($"The number of {input} is {count}");
            } else
            {
                Console.WriteLine($"There is no {input} in the array.");
            }
          
        }
    }
}
