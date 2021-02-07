using System;

namespace plus15
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            minutes += 15;
            if (minutes > 59)
            {
                hour++;
                if (hour >= 24)
                {
                    if (minutes - 60 < 10) Console.WriteLine(hour - 24 + ":0" + (minutes - 60));
                    else Console.WriteLine(hour - 24 + ":" + (minutes - 60));
                }
                else
                {
                    if (minutes - 60 < 10) Console.WriteLine(hour  + ":0" + (minutes - 60));
                    else Console.WriteLine(hour+":" + (minutes - 60));
                }
            }
            else
            {
                Console.WriteLine(hour + ":" + minutes);
            }
        }
    }
}
