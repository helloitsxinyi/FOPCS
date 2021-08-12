﻿using System;

namespace ExerciseF
{
    class ExerciseF
    {
        public static void Main()
        {
            Console.WriteLine("Enter the question you would like to test. Enter 'exit' to end.");
            string question = Console.ReadLine();

            switch (question)
            {
                case "1":
                    Q1.solution();
                    break;
                case "2":
                    Q2.solution();
                    break;
                case "3":
                    Q3.solution();
                    break;
                case "4":
                    Q4.solution();
                    break;
                case "5":
                    Q5.solution();
                    break;
                case "6":
                    Q6.solution();
                    break;
                case "exit":
                    break;
                default:
                    Console.WriteLine("Please enter a number from 1 to 5!");
                    Main();
                    break;
            }
        }
    }
}
