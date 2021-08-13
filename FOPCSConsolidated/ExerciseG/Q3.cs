using System;
namespace ExerciseG
{
    public class Q3
    {
        public static void solution()
        {
            Console.WriteLine("Please select the part you would like to view: ");
            string part = Console.ReadLine();

            switch(part)
            {
                case "a":
                    partA();
                    break;
                case "b":
                    partB();
                    break;
            }
                       
            static void partA()
            {
                int[,] studentMarks = new int[,]
            {
                    {56,84,68,28},
                    {94,73,31,96},
                    {41,63,36,90},
                    {99,9,18,17},
                    {62,3,65,75},
                    {40,96,53,23},
                    {81,15,27,30},
                    {21,70,100,22},
                    {88,50,13,12},
                    {48,54,52,78},
                    {64,71,67,25},
                    {16,93,46,72}
            };



                for (int i = 0; i < studentMarks.GetLength(0); i++)
                {
                    int totalMarks = 0;
                    for (int j = 0; j < studentMarks.GetLength(1); j++)
                    {
                        totalMarks += studentMarks[i, j];

                    }
                    Console.WriteLine($"Student {i + 1}'s total marks are: {totalMarks}.");
                    ExerciseG.Main();
                }
            }

            static void partB()
            {

            }
    }
}
