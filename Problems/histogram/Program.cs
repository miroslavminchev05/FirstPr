using System;

namespace histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;
            double n1 = n;
            while (n1 > 0)
            {
                int a = int.Parse(Console.ReadLine());
                if (a < 200) p1++;
                if (a >= 200 && a < 400) p2++;
                if (a >= 400 && a < 600) p3++;
                if (a >= 600 && a < 800) p4++;
                if(a>=800) p5++;
                n1--;
            }
            Console.WriteLine("{0:F2}%", p1 / n*100);
            Console.WriteLine("{0:F2}%", p2 / n*100);
            Console.WriteLine("{0:F2}%", p3 / n*100);
            Console.WriteLine("{0:F2}%", p4 / n*100);
            Console.WriteLine("{0:F2}%", p5 / n*100);
        }
    }
}
