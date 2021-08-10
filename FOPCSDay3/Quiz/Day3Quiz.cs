using System;

namespace Quiz
{
    class Day3Quiz
    {
        static void Main(string[] args)
        {
            int price = 500;
            Console.WriteLine("Welcome to ISS Gadget Shop!");
            Console.WriteLine("Number of items to purchase: ");
            int quantity = int.Parse(Console.ReadLine());
            double discount;

            // is it recommended to store d qty * price as another variable? might take up more memory?
            // ANS: recommended to create. so that the coding is clearer.
            // expresions in conditional statement, syntax is correct but less readable
            if (quantity * price <= 2000)
            {
                discount = 0;
            }
            else if (quantity * price <= 3000)
            {
                discount = 0.03;
            }
            else if (quantity * price <= 6000)
            {
                discount = 0.05;
            }
            else
            {
                discount = 0.08;
            }
            double payment = (1 - discount) * (quantity * price);
            Console.WriteLine($"Please pay ${payment:0,0.00}");
        }
    }
}
