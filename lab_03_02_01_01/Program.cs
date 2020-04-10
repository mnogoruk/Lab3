using System;

namespace lab_03_02_01_01
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, x1, x2, y;
            x1 = 0;
            x2 = 3.2;

            Console.WriteLine("x\ty");
            x = x1;
            do
            {
                y = Math.Sin(x);
                Console.WriteLine("{0:f4}\t{1:f4}", x, y);
                x = x + 0.1;
            } while (x <= x2);

        }
    }
}
