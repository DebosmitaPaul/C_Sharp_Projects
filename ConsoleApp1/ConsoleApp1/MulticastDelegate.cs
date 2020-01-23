using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class MulticastDelegate
    {
        static int c = 0;
        public static void Add(int a, int b, out int c) => c = a + b; // 12
        public static void Sub(int a, int b,out int c) => c = a - b; // 8
        public static void Multi(int a, int b, out int c) => c = a * b; //20
        public static void Div(int a, int b, out int c) => c = a / b; //5

        public static void Display() => Console.WriteLine("Display1...");
        public static void Print() => Console.WriteLine("Print1...");
    }
    class CMain_07
    {
        public delegate void OperationDelegate(int a, int b, out int c);
        public delegate void DisplayDelegate();
        static void Main_07(string[] args)
        {
            OperationDelegate op = new OperationDelegate(MulticastDelegate.Add);
            op += MulticastDelegate.Sub;
            op += MulticastDelegate.Multi;
            op += MulticastDelegate.Div;

            op(10, 2, out int result);
            Console.WriteLine($"Result : {result}"); // o/p = 5

            DisplayDelegate dis = new DisplayDelegate(MulticastDelegate.Display);
            dis += MulticastDelegate.Print;
            dis(); // Display1...
                   // Print1...


        }

    }
}
