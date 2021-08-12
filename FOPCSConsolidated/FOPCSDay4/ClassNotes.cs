using System;

namespace ClassNotes
{
    class ClassNotes
    {
        static void Main(string[] args)
        {
            // string comparison
            string a = "bbc";
            string b = "Cac";
            Console.WriteLine(a.CompareTo(b));
            Console.WriteLine(b.CompareTo(a));

            // splitting strings
            string s = "name1, name2,  name3";
            string[] stringList = s.Split(',');
            for (int i = 0; i < stringList.Length; i++)
            {
                Console.WriteLine("test" + stringList[i]);
            }
        }

    }
}
