﻿using System;
using MyMethod;

namespace JenkinsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to Jenkins !");
            Console.WriteLine("This is the first use of Jenkins");
            Console.WriteLine("---***---");
            MyMaths myMaths = new MyMaths();
            int x = myMaths.add(4, 5);
            int y = myMaths.multiply(4, 5);
            Console.WriteLine($"{x} ------ {y}");
            Console.ReadLine();
        }
    }
}
