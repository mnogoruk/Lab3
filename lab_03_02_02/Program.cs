using System;

namespace lab_03_02_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int k, m, i, s =0;
            k = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());

            for (i = 1; i <= 100; i++)
            {
                if (i > k && i < m) continue;
                s += i;
            }

            Console.WriteLine(s);
        }
    }
}
