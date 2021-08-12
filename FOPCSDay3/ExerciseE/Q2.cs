using System;
namespace ExerciseE
{
    public class Q2
    {
        public static void solution()
        {
          
            for (double num = 1; num <= 10; num++)
            {

                double inverse = 1 / num;
                double root = Math.Sqrt(num);
                double square = Math.Pow(num, 2);

                Console.WriteLine($"Number{num: 0.0}\tInverse{inverse: 0.0##}\tSquare root{root: 0.0##}\tSquare {square: 0.0}");
          
            }


            ExerciseE.Main();
        }
    }
}