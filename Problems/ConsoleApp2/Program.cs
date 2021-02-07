using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                int zv = 2;
                int ch = (n - 2) / 2;
                for(int i = 1; i <= (n + 1) / 2; i++)
                {
                    for(int j = 1; j <= ch; j++)
                    {
                        Console.Write("-");
                    }
                    for(int j = 1; j <= zv; j++)
                    {
                        Console.Write("*");
                    }
                    for (int j = 1; j <= ch; j++)
                    {
                        Console.Write("-");
                    }
                    Console.WriteLine();
                    zv += 2;
                    ch--;
                    
                }
                for (int i = 1; i <= n / 2 ; i++)
                {
                    Console.Write("|");
                    for (int j = 1; j <= n - 2; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("|");
                }
            }
            else
            {
                int zv = 1;
                int ch = (n - 1) / 2;
                for(int i = 1; i <= (n + 1) / 2; i++)
                {
                    for(int j = 1; j <= ch; j++)
                    {
                        Console.Write("-");
                    }
                    for(int j = 1; j <= zv; j++)
                    {
                        Console.Write("*");
                    }
                    for (int j = 1; j <= ch; j++)
                    {
                        Console.Write("-");
                    }
                    Console.WriteLine();
                    zv = zv + 2;
                    ch--;
                }
                for(int i = 1; i <= n / 2 ; i++)
                {
                    Console.Write("|");
                    for(int j = 1; j <= n - 2; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("|");
                }
            }
            
        }
    }
}
