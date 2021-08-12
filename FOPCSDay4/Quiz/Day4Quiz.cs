using System;

namespace FOPCSDay4
{
    class Day4Quiz
    {
        static void Main()
        {

            // if ask user to input PIN, good to put in string instead of int. because "000001" may be a password that the user wants to set.

            Console.WriteLine("Welcome to the Bank of ISS \n Enter your PIN: ");
            int inputPin = int.Parse(Console.ReadLine());
            int pin = 123456;
            int count = 1;

            while (inputPin != pin && count < 3)
            {
                Console.WriteLine("Incorrect PIN. Please try again. \n Enter your PIN: ");
                inputPin = int.Parse(Console.ReadLine());
                count += 1;
            }

            if (inputPin == pin)
            {
                Console.WriteLine("PIN accepted. You can access your account now.");
            }
            else {
                Console.WriteLine("Too many wrong PIN entries. Your account is now locked.");
            }                  
        }
    }
}