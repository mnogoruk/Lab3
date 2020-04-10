using System;

namespace lab_03_02_01_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            int temp;
            temp = a;
            while (temp != b)
            {
                a = temp;
                if (a < b)
                {
                    temp = a;                
                    a = b;
                    b = temp;
                }
                temp = a - b;
                a = b;
            }
            Console.WriteLine(temp);
        }
    }
}
