using System;

namespace magics
{
    class Program
    {
        static int Pr(int n)
        {
            int pr = 1;
            while (n > 0)
            {
                pr = pr * (n % 10);
                n = n / 10;
            }
            return pr;
        }
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 100000; i < 1000000; i++)
            {
                if (Pr(i) == n) Console.Write(i + " ");

            }
        }
    }
}
