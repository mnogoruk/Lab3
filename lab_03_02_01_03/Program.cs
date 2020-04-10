using System;

namespace lab_03_02_01_03
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            double x, y, x1, x2;

            x1 = -2;
            x2 = 2;

            Console.WriteLine("x\ty");
            x = x1;
            while(x <= x2)
            {
                y = Math.Sin(x);
                Console.WriteLine("{0:f1}\t{1:f4}", x, y);
                x = x + 0.1;
            }


            int a, b, temp;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            temp = a;
            do
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
            } while (temp != b);

            Console.WriteLine(temp);


        }
    }
}
