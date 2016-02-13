using System;

namespace TrianglePatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            DisplayPatternA();
            DisplayPatternB();
            DisplayPatternC();
            DisplayPatternD();

            Console.ReadLine();
        }

        static void DisplayPatternA()
        {

            Console.WriteLine("");
            Console.WriteLine(" Output A");
            Console.WriteLine("");
            int n = 10;
            int i, j, k;

            for (i = 1; i <= n; i++)
            {

                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }

        }

        static void DisplayPatternB()
        {
            int n = 10;
            int i, j, k;

            Console.WriteLine("");
            Console.WriteLine(" Output B");
            Console.WriteLine("");
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n - i; j++)
                {
                    // Console.Write(" ");
                }
                for (k = 1; k <= j; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }

        static void DisplayPatternC()
        {
            Console.WriteLine("");
            Console.WriteLine(" Output C");
            Console.WriteLine("");
            int n = 10;
            int i, j, k;
            for (i = 0; i < n; i++)
            {
                for (k = 0; k < i; k++)    //using i to control number of spaces
                    Console.Write(" ");
                for (j = n; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }




        }

        static void DisplayPatternD()
        {
            Console.WriteLine("");
            Console.WriteLine(" Output D");
            Console.WriteLine("");

            int n = 10;
            int i, j, k;
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

        }
    }
}