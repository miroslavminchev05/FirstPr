using System;

namespace function
{
    class Program
    {

        static int even(int n)
        {
            int sum = 0;
            n = Math.Abs(n);
            while (n > 0)
            {
                if (n % 2 == 0) sum += n % 10;
                n /= 10;
            }
            return sum;
        }
        static int odd(int n)
        {
            n = Math.Abs(n);
            int sum = 0;
            while (n > 0)
            {
                if (n % 2 == 1) sum += n % 10;
                n /= 10;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(even(n)*odd(n));
        }
    }
}
