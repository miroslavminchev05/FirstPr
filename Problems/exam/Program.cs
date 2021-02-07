using System;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int h1 = int.Parse(Console.ReadLine());
            int m1 = int.Parse(Console.ReadLine());
            int h2 = int.Parse(Console.ReadLine());
            int m2 = int.Parse(Console.ReadLine());
            if (m1 - m2 < 0)
            {
                if (h1 - h2 == 1)
                {
                    if (60 + m1 - m2 > 30)
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine("{0} minutes before the start", 60 + m1 - m2);
                    }
                    else
                    {
                        Console.WriteLine("On time");
                        Console.WriteLine("{0} minutes before the start", 60 + m1 - m2);
                    }
                }
                else if (h1 == h2)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine("{0} minutes after the start", m2 - m1);
                }
                else if (h1 - h2 > 1)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine("{0}:{1} hours before the start", h1 - h2 - 1, 60 + m1 - m2);
                }
                else if (h1 - h2 < 0)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine("{0}:{1} hours after the start", h2 - h1 , 60 + m1 - m2);
                }
                
            }
            if (m1 - m2 > 0)
            {
                if (h1 - h2 == 0)
                {
                    if (m1 - m2 > 30)
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine("{0} minutes before the start", m1 - m2);
                    }
                    else
                    {
                        Console.WriteLine("On time");
                        Console.WriteLine("{0} minutes before the start", m1 - m2);
                    }
                }
                else if (h1 - h2 ==-1)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine("{0} minutes after the start",  60+m2-m1) ;
                }
                else if (h1 - h2 < -1)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine("{0}:{1} hours after the start",h2-h1-1, 60 + m2 - m1);
                }
                else if (h1 - h2 == 1)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine("{0} minutes after the start", m1-m2);
                }
                else if (h1 - h2 > 1)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine("{0}:{1} hours after the start", h1-h2, m1-m2);
                }
            }
            if (m1 == m2)
            {
                if (h1 == h2)
                {
                    Console.WriteLine("On time");

                }
                else if (h1 > h2)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine("{0}:00 hours before the start", h1 - h2);
                }
                else if (h2 > h1)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine("{0}:00 hours after the start", h2-h1);
                } 
                    
            }
        }
    }
}
