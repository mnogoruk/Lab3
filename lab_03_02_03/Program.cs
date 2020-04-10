using System;

namespace lab_03_02_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            int cx, cy;
            int r2 = 2, r1 = 1 ;
            bool playNext = true;
            int sum = 0;
            char answer;
            Random random = new Random();
            cx = random.Next() % 2;
            cy = random.Next() % 2;


            do
            {
                Console.WriteLine("Enter x: ");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter y: ");
                y = int.Parse(Console.ReadLine());

                if (Math.Pow(x-cx, 2) + Math.Pow(y-cy, 2) <= Math.Pow(r1, 2)){
                    sum += 10;
                }
                else if (Math.Pow(x - cx, 2) + Math.Pow(y - cy, 2) <= Math.Pow(r2, 2))
                {
                    sum += 5;
                }
                Console.WriteLine("sum: {0}\nplay next - y/n", sum);

                answer = char.Parse(Console.ReadLine());
                if (answer == 'n' || answer == 'N')
                {
                    playNext = false;
                }

            } while (playNext);
        }
    }
}
