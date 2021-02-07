using System;
using System.Globalization;

namespace diamand
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftRight = (n - 1) / 2;
            int mid = n - 2 * leftRight - 2;
            if (n % 2 == 1) { 
            for (int i = 1; i <= n; i++)
            {

                
                    if (i <= n / 2)
                    {
                        for (int j = 1; j <= leftRight; j++)
                        {
                            Console.Write("-");
                        }
                        Console.Write("*");
                        if (mid < 0)
                        {
                            for (int j = 1; j <= leftRight; j++)
                            {
                                Console.Write("-");
                            }
                        }
                        else
                        {
                            for (int j = 1; j <= mid; j++)
                            {
                                Console.Write("-");
                            }
                            Console.Write("*");
                            for (int j = 1; j <= leftRight; j++)
                            {
                                Console.Write("-");
                            }
                        }

                        Console.WriteLine();
                        leftRight--;
                        mid += 2;
                    }
                    else
                    {
                        for (int j = 1; j <= leftRight; j++)
                        {
                            Console.Write("-");
                        }
                        Console.Write("*");
                        if (mid < 0)
                        {
                            for (int j = 1; j <= leftRight; j++)
                            {
                                Console.Write("-");
                            }
                        }
                        else
                        {
                            for (int j = 1; j <= mid; j++)
                            {
                                Console.Write("-");
                            }
                            Console.Write("*");
                            for (int j = 1; j <= leftRight; j++)
                            {
                                Console.Write("-");
                            }
                        }

                        Console.WriteLine();
                        leftRight++;
                        mid -= 2;
                    }

                }
                


            }
            if (n % 2 == 0)
            {
                for (int i = 1; i < n; i++)
                {


                    if (i < n / 2)
                    {
                        for (int j = 1; j <= leftRight; j++)
                        {
                            Console.Write("-");
                        }
                        Console.Write("*");
                        if (mid < 0)
                        {
                            for (int j = 1; j <= leftRight; j++)
                            {
                                Console.Write("-");
                            }
                        }
                        else
                        {
                            for (int j = 1; j <= mid; j++)
                            {
                                Console.Write("-");
                            }
                            Console.Write("*");
                            for (int j = 1; j <= leftRight; j++)
                            {
                                Console.Write("-");
                            }
                        }

                        Console.WriteLine();
                        leftRight--;
                        mid += 2;
                    }
                    else
                    {
                        for (int j = 1; j <= leftRight; j++)
                        {
                            Console.Write("-");
                        }
                        Console.Write("*");
                        if (mid < 0)
                        {
                            for (int j = 1; j <= leftRight; j++)
                            {
                                Console.Write("-");
                            }
                        }
                        else
                        {
                            for (int j = 1; j <= mid; j++)
                            {
                                Console.Write("-");
                            }
                            Console.Write("*");
                            for (int j = 1; j <= leftRight; j++)
                            {
                                Console.Write("-");
                            }
                        }

                        Console.WriteLine();
                        leftRight++;
                        mid -= 2;
                    }

                }
            }
        }
    }
}
