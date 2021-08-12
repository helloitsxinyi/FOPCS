using System;
namespace FOPCS
{
    class ThirdProgram
    {
       /* you only get error for "more than 1 entry point defined"
          if Main method appears in >1 classes.
          If Main method appears in 1 class each for 2 projects,
          the error will not be shown.*/

        //static void Main(string[] args)

        // member names cannot be same as enclosing type, so cannot name it ThirdProgram
        static void ThirdProgramMethod()
        {
            Console.WriteLine("This is my third program!");
            Console.WriteLine("Waw!");

            int a = 1;
            a = a + 1;
            Console.WriteLine("a");
        }
    }
}
