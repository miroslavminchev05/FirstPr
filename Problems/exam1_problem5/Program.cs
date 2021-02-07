using System;

namespace exam1_problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int a = 0;
            for(int i = 1; i <= 9; i++)
            {
                for(int j = 1; j <= 9; j++)
                {
                    for(int p = 1; p <= 9; p++)
                    {
                        for(int q=1;q<=9;q++)
                        {
                            if (i + j == n && p % 2 == 0 && (q == 3 || q == 6))
                            {
                                Console.Write("{0}{1}{2}{3} ", i, j, p, q);
                                a++;
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Count of winner numbers: {0}", a); 
        }
    }
}
