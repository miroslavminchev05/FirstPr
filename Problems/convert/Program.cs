using System;
using System.Security;

namespace convert
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            var start = Console.ReadLine();
            var end = Console.ReadLine();
            if (start == "mm") a = a / 1000.0;
            if (start == "cm") a = a / 100.0;
            if (start == "mi") a = a / 0.000621371192;
            if (start == "km") a = a / 0.001;
            if (start == "ft") a = a / 3.2808399;
            if (start == "yd") a = a / 1.0936133;
            if (start == "in") a = a / 39.3700787;
            if (end == "mm") a = a * 1000.0;
            if (end == "cm") a = a * 100.0;
            if (end == "mi") a = a * 0.000621371192;
            if (end == "km") a = a * 0.001;
            if (end == "ft") a = a * 3.2808399;
            if (end == "yd") a = a * 1.0936133;
            if (end == "in") a = a * 39.3700787;
            Console.WriteLine(a+" "+end);

        }
    }
}
