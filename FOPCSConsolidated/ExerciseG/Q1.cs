using System;
namespace ExerciseG
{
    public class Q1
    {
        public static void solution()
        {
            double[] sales = new double[12];

            // partA
            try
            {
                for (int month = 0; month < 12; month++)
                {
                    Console.Write($"Please enter the sales of month {month + 1}: ");
                    sales[month] = double.Parse(Console.ReadLine());
                }
                Console.WriteLine("Here are the sales of all 12 months that you have entered: ");

                for (int i = 0; i < 12; i++)
                {
                    Console.WriteLine($"Month {i + 1}: {sales[i]}");
                }


                // partB
                int maxMonth = 0;
                double maxMonthSales = sales[0];

                for (int i = 0; i < 12; i++)
                    if (sales[i] > maxMonthSales)
                    {
                        maxMonth = i + 1;
                        maxMonthSales = sales[i];
                    }
                Console.WriteLine($"The month with max sales is: Month {maxMonth}.");

                // partC
                int minMonth = 0;
                double minMonthSales = sales[0];

                for (int i = 0; i < 12; i++)
                    if (sales[i] < minMonthSales)
                    {
                        minMonth = i + 1;
                        minMonthSales = sales[i];
                    }
                Console.WriteLine($"The month with min sales is: Month {minMonth}.");


                // partD
                double totalSales = 0;

                for (int i = 0; i < 12; i++)
                {
                    totalSales += sales[i];

                }

                double average = totalSales / sales.GetLength(0);
                Console.WriteLine($"The average monthly sales is {average: 0,0,0.00}.");

                ExerciseG.Main();

            }

            catch (FormatException e)
            {
                Console.WriteLine("Invalid input! Please try again.");
                Q1.solution();
            }
        }
    }
}

