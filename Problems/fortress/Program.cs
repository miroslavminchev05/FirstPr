using System;
using System.Globalization;

namespace fortress
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            String unicode = "\u005c";

            Console.Write("/");
            for (int j = 1; j <= n / 2; j++)
            {
                Console.Write("^");
            }
            Console.Write(unicode);
            for (int j = 1; j <= (2 * n - n / 2 * 2 - 4); j++)
            {
                Console.Write("_");
            }
            Console.Write("/");
            for (int j = 1; j <= n / 2; j++)
            {
                Console.Write("^");
            }
            Console.Write(unicode);
            Console.WriteLine();
            for (int i = 1; i < n - 2; i++)
            {
                Console.Write("|");
                for (int j = 0; j <= 2 * n - 3; j++)
                {
                    Console.Write(" ");

                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.Write("|");
            for(int i = 1; i <= n / 2 + 1; i++)
            {
                Console.Write(" ");
            }
            for(int i=1;i<= (2 * n - n / 2 * 2 - 4); i++)
            {
                Console.Write("_");
            }
            for (int i = 1; i <= n / 2 + 1; i++)
            {
                Console.Write(" ");
            }
            Console.Write("|");
            Console.WriteLine();
            Console.Write(unicode);
            for(int i = 1; i <= n / 2; i++)
            {
                Console.Write("_");
            }
            Console.Write("/");
            for (int i = 1; i <= (2 * n - n / 2 * 2 - 4); i++)
            {
                Console.Write(" ");
            }
            Console.Write(unicode);
            for (int i = 1; i <= n / 2; i++)
            {
                Console.Write("_");
            }
            Console.Write("/");

        }


    }

}
