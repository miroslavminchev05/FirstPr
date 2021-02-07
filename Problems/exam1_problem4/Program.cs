using System;

namespace exam1_problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int x = 0;
            int y = 0;
            int z = 0;
            for(int i = 0; i < n; i++)
            {
                var a = int.Parse(Console.ReadLine());
                if (a % 2 == 0) x++;
                if (a % 3 == 0) y++;
                if (a % 5 == 0) z++;

            }
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}
