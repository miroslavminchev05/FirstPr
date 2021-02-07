using System;

namespace exam1_problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            var sektor = Console.ReadLine();
            var red = int.Parse(Console.ReadLine());
            var col = int.Parse(Console.ReadLine());
            if(sektor=="Sector A")
            {
                Console.WriteLine("{0} profit is {1:F2} lv.", sektor, 11.6 * red * col);
            }
            if (sektor == "Sector B")
            {
                Console.WriteLine("{0} profit is {1:F2} lv.", sektor, 14.5 * red * col);
            }
            if (sektor == "Sector C")
            {
                Console.WriteLine("{0} profit is {1:F2} lv.", sektor, 16.1 * red * col);
            }
            if (sektor == "Sector D")
            {
                Console.WriteLine("{0} profit is {1:F2} lv.", sektor, 8.4 * red * col);
            }
        }
    }
}
