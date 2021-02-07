using System;

namespace cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double a = 1.0;
            switch (type)
            {
                case "Primiere": a = 12.00;
                    ;break;
                case "Normal":
                    a=7.50;break;
                case "Discount":
                    a=5.00;break;
            }
            Console.WriteLine(Math.Round((r * c * a), 2));
            
        }
    }
}
