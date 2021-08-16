using System;

namespace Day6Quiz
{
    class TaxCalculator
    {
        //these arrays is visible in all the static method, 
        //so you can use them in your method implementation

        static int[] minIncomeArray = new int[]
            { 20000, 30000, 40000, 80000,
              120000, 160000, 200000, 320000 };
        static double[] taxRateArray = new double[]
            { 0.02, 0.035, 0.07, 0.115,
              0.15, 0.17, 0.18, 0.20 };
        static int[] basePayableAmountArray = new int[]
            { 0, 200, 550, 3350,
              7950, 13950, 20750, 42350 };

        static void Main(string[] args)
        {
            try
            {
                int annualIncome = AskForIncome();
                int taxBracket = GetTaxBracket(annualIncome);
                double taxPayable =
                    CalculateIncomeTax(annualIncome, taxBracket);
                PrintResult(annualIncome, taxPayable);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid input! Please try again.");
            }          
        }

        // YOUR CODE HERE

        static int AskForIncome()
        {
            Console.WriteLine("Please enter your taxable income: ");
            int annualIncome = Convert.ToInt32(double.Parse(Console.ReadLine()));
            return annualIncome;
        }

        static int GetTaxBracket(int annualIncome)
        {
            int taxBracket = 0;
            for (int i = 0; i < minIncomeArray.Length; i++)
            {
                if (annualIncome < 20000)
                {
                    return -1;
                }
               
                if (minIncomeArray[i] < annualIncome)
                {
                    taxBracket = i;                                     
                }            
            }
            return taxBracket;
        }

        static double CalculateIncomeTax(int annualIncome, int taxBracket)
        {
            double taxPayable = 0;

            if (taxBracket == -1)
            {
                return Convert.ToDouble(taxPayable);
            }
            taxPayable = (annualIncome - minIncomeArray[taxBracket]) * taxRateArray[taxBracket] + basePayableAmountArray[taxBracket];

            return taxPayable;
        }

        static void PrintResult(int annualIncome, double taxPayable)
        {
            Console.Write($"For taxable annual income of ${annualIncome:#,#,0.00}, the tax payable amount is ${taxPayable:#,#,0.00}");
        }        
    }
}
