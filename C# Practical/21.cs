﻿using System;
namespace OOPs
{
    public class MultiInheritence
    {
        class MainClass
        {
            public void Print()
            {
                Console.WriteLine("Print");
            }
        }
        class Subclass : MainClass
        {
            public void Print1()
            {
                Console.WriteLine("Print 1");
            }

        }
        class Subclass2 : Subclass
        {

            public void Print2()
            {
                Console.WriteLine("Print 2");
            }
            static void Main(string[] args)
            {
                Subclass2 s = new Subclass2(); 
                s.Print();
                s.Print1();
                s.Print2();
                Console.ReadLine();
            }

        }
    }
}