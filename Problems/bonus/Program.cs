using System;

namespace bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double bonus = 0;
            if (n <= 100) bonus = 5;
            if (n > 100) bonus =0.2*n;
            if (n > 1000) bonus = 0.1*n;
            if (n % 2 == 0) bonus++;
            if (n % 10 == 5) bonus += 2;
            Console.WriteLine(bonus);
            Console.WriteLine( (bonus + n));
        }
    }
}
