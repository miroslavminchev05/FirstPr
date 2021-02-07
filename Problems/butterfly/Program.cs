using System;

namespace butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            String unicode = "\u005c";
            for (int i = 1; i <= n - 2; i++)
            {
                if (i % 2 == 1)
                {
                    for (int j = 1; j <= n - 2; j++)
                    {
                        Console.Write("*");
                    }
                    Console.Write(unicode+" /");
                    for (int j = 1; j <= n - 2; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                else
                {
                    for (int j = 1; j <= n - 2; j++)
                    {
                        Console.Write("-");
                    }
                    Console.Write(unicode+" /");
                    for (int j = 1; j <= n - 2; j++)
                    {
                        Console.Write("-");
                    }
                    Console.WriteLine();
                }    }
            for(int i = 1; i < n; i++)
            {
                Console.Write(" ");
            }
            Console.Write("@");
            for (int i = 1; i < n; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine();
            for (int i = 1; i <= n - 2; i++)
            {
                if (i % 2 == 1)
                {
                    for (int j = 1; j <= n - 2; j++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("/ "+unicode);
                    for (int j = 1; j <= n - 2; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                else
                {
                    for (int j = 1; j <= n - 2; j++)
                    {
                        Console.Write("-");
                    }
                    Console.Write("/ "+unicode);
                    for (int j = 1; j <= n - 2; j++)
                    {
                        Console.Write("-");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
