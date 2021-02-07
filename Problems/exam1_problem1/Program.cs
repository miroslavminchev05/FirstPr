using System;

namespace exam1_problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            var cena_str = float.Parse(Console.ReadLine());
            var col_ban = float.Parse(Console.ReadLine());
            var col_or = float.Parse(Console.ReadLine());
            var col_rasp = float.Parse(Console.ReadLine());
            var col_str = float.Parse(Console.ReadLine());
            float cena_rasp = cena_str / 2;
            float cena_or = 60 * cena_rasp / 100;
            float cena_ban = 20 * cena_rasp / 100;
            Console.WriteLine(cena_str * col_str + cena_ban * col_ban + cena_or * col_or + cena_rasp * col_rasp);

        }
    }
}
