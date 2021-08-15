using System;
namespace ExerciseH
{
    public class Q2
    {
        public static void solution()
        {            
            try
            {
                Console.WriteLine("Enter the length of your array: ");
                int length = int.Parse(Console.ReadLine());
                int[] arr = new int[length];

                Console.WriteLine("Enter the values of your array: ");

                for (int i = 0; i < length; i++)
                {
                    Console.WriteLine($"Enter the value of the number {i + 1} element: ");
                    arr[i] = int.Parse(Console.ReadLine());
                }

                PrintArray(arr);
            
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid input! Please input an integer.");
                Q2.solution();
            }       
        }

        private static void PrintArray(int[] arr)
        {            
            Console.WriteLine("Your array is [{0}]", string.Join(",", arr));
        }
                       
    }
}

