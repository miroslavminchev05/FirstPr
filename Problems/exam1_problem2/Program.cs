using System;

namespace exam1_problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            var cena_t = double.Parse(Console.ReadLine());
            var cena_World = double.Parse(Console.ReadLine());
            double cena_shorts = 75*cena_t/100;
            double cena_socks = 20*cena_shorts/100;
            double cena_butonki = 2 * (cena_shorts + cena_t);
            double final = 85 * (cena_t + cena_shorts + cena_socks + cena_butonki)/100 ;
            double final1 = Math.Round(final, 2, MidpointRounding.AwayFromZero);
            if (final >= cena_World)
            {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine("His sum is {0:F2} lv.", final1);
            }
            else
            {
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine("He needs {0:F2} lv. more.", (cena_World - final1));
            }
        }
    }
}
