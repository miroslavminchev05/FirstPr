using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            double f= (1/Math.Sqrt(5))*(Math.Pow(((1+Math.Sqrt(5))/2),n+1)- Math.Pow(((1 - Math.Sqrt(5)) / 2), n+1));
            Console.WriteLine(Math.Round(f,0));
        }
    }
}
