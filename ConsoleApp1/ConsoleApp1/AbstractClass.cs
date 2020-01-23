using System;
using System.Collections.Generic;
using System.Text;
using static System.Math;

namespace ConsoleApp1
{
    public abstract class MyBaseClass02
    {
        public string s = "abstract";
        public MyBaseClass02(string str)
        {
            s = str;
            Console.WriteLine("In abstract constractor " + s);
        }
        //int c = 0;
        public abstract int sum(int a, int b); //=> c = a + b;
        public void display() => Console.WriteLine("Hello in Abstract Class "+s);

    }
    public class MyChildClass02 : MyBaseClass02
    {
        public MyChildClass02(string sc) : base(sc)
        {
            base.s = sc;
            Console.WriteLine("In Child Class "+sc + s);
            double c = Pow(2.3, 3.4);
        }
        int c = 0;

        public override int sum(int a, int b) => c = a + b+100;

    }
    class AbstractClass
    {
        static void Main_04(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyBaseClass02 b = new MyChildClass02("Debosmita"); // AbsClass -> childClass
            b.display();           
            Console.WriteLine(b.sum(3, 2));
        }
    }
}
