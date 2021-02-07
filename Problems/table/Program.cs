using System;

namespace table
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int b = n - 1;
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (j < n - i)
                    {
                        Console.Write(i + j + 1);
                    }
                    else
                    {
                        
                        Console.WriteLine(b);
                        b--;
                    }
                    b = n - 1;
                    
                }
                
                Console.WriteLine();
            }
        }
    }
}
