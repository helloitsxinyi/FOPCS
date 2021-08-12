using System;
namespace ExerciseE
{
    public class Q2
    {
        public static void solution()
        {
            Console.WriteLine("NO\tINVERSE\t\tSQUARE ROOT\tSQUARE");
            Console.WriteLine("------------------------------------------------------");
            
            for (double num = 1; num <= 10; num++)
            {

                double inverse = 1 / num;
                double root = Math.Sqrt(num);
                double square = Math.Pow(num, 2);

                Console.WriteLine($"{num: 0.0}\t{inverse: 0.0##}\t\t{root: 0.0##}\t\t{square: 0.0}");
          
            }

            ExerciseE.Main();
        }
    }
}