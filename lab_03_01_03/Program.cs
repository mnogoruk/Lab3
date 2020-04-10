using System;

namespace lab_03_01_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Enter year");
            year = int.Parse(Console.ReadLine());
            
            if (year % 400 == 0)
            {
                Console.WriteLine("Yes");
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine("NO");
            }
            else if (year % 4 == 0)
            {
                Console.WriteLine("Yse");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
