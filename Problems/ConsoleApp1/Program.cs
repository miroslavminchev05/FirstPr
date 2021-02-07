using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
            if (str == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome!");

            }
            else Console.WriteLine("Wrong Password!");
        }
    }
}
