using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            while (Math.Abs(a - b) > 0)
            {
                if (b > a) b = b - a;
                else a = a - b;
            }
            if (a == 0) Console.WriteLine(b);
            else Console.WriteLine(a);
        }
    }
}
