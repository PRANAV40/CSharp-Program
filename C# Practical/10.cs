﻿using System;
namespace myproject
{
    public class Pattern_PyramidInverse
    {
        public static void Main(string[] args)
        {
            int space, rows;
            Console.WriteLine("A program to print pyramid pattern");
            Console.WriteLine("Enter the number of rows:");
            rows = int.Parse(Console.ReadLine());

            for (int i = rows; i >= 1; i--)
            {
                for (space = i; space <= rows; space++)
                {
                    Console.Write(" ");
                }
                for (int star = (i * 2); star > 1; star--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}