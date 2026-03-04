namespace DotnetPatterns;

using System;
using System.Drawing;

class Program
{
    static void Main()
    {
        // This is a simple pattern printing program that prints a right-angled triangle of asterisks.
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        //inverse right-angled triangle
        for (int i = 5; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

            Console.WriteLine();

        // pyramid pattern
        int n = 5;

        for (int i = 1; i <= n; i++)
        {
            // spaces
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }

            // stars
            for (int k = 1; k <= (2 * i - 1); k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        Console.WriteLine();

        // inverse pyramid pattern
        int num = 5;

        for (int i = num; i >= 1; i--)
        {
            for (int j = 1; j <= num - i; j++)
            {
                Console.Write(" ");
            }

            for (int k = 1; k <= (2 * i - 1); k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        Console.WriteLine();

        // diamond pattern

        int size = 5;

        // Upper part
        for (int i = 1; i <= size; i++)
        {
            for (int j = 1; j <= size - i; j++)
                Console.Write(" ");

            for (int k = 1; k <= (2 * i - 1); k++)
                Console.Write("*");

            Console.WriteLine();
        }

        // Lower part
        for (int i = size - 1; i >= 1; i--)
        {
            for (int j = 1; j <= size - i; j++)
                Console.Write(" ");

            for (int k = 1; k <= (2 * i - 1); k++)
                Console.Write("*");

            Console.WriteLine();
        }
    }
}