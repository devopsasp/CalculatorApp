﻿using System;

namespace CalculatorApp
{
    public class Calculator
    {
        public int add(int a,int b)
        {
            return a + b;
        }
        public int subtract(int a,int b)
        {
            return a - b;
        }
        public int multiply (int a,int b)
        {
            return a * b;
        }
        public int divide(int a,int b)
        {
            return a / b;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Calculator obj = new Calculator();
            Console.WriteLine(obj.add(13, 34));
            Console.WriteLine(obj.multiply(11, 15));

        }
    }
}
