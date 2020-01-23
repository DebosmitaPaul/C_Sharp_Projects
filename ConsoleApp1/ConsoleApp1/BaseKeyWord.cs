using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class MyBaseClass01
    {
        int c = 0;
        public int e = 100;
        public virtual int sum(int a, int b) => c = a + b;
        public virtual void display() => Console.WriteLine("Hello in BaseClass");
    }
    class MyChildClass01 : MyBaseClass01
    {
        public override void display()
        {
            base.display();
            Console.WriteLine("Hello in ChildClass");
        }

        public override int sum(int a, int b) 
        {
            return a + b + base.e ; 
        }
    }
    class BaseKeyWord
    {
        static void Main_03(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyBaseClass01 b = new MyBaseClass01(); //base
            Console.WriteLine(b.sum(3, 2)); //base
            b.display();
            MyBaseClass01 bc = new MyChildClass01();//Child then base
            Console.WriteLine(bc.sum(5, 2)); //Child
            bc.display();// Hello in BaseClass
                         // Hello in ChildClass
            MyChildClass01 c = new MyChildClass01(); //child then base
            Console.WriteLine(c.sum(30, 2)); //child

        }
    }
}
