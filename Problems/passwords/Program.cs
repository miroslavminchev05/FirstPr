using System;

namespace passwords
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var l = int.Parse(Console.ReadLine());
            for(int i = 1; i < n; i++)
            {
                
                for(int j = 1; j < n; j++)
                {
                    
                    for(int x = 97; x <= 96 + l; x++)
                    {
                        
                        for(int y = 97; y <= 96 + l; y++)
                        {
                            
                            for(int m = i + 1; m <= n; m++)
                            {
                                Console.Write(i);
                                Console.Write(j);
                                Console.Write((Convert.ToChar(x)).ToString());
                                Console.Write((Convert.ToChar(y)).ToString());
                                Console.Write(m + " ");
                            }
                        }
                    }
                }
            }
        }
    }
}
