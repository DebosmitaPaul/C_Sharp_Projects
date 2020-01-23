using System;

namespace ConsoleApp1
{
    class MyBaseClass
    {
        int c = 0;
        public virtual int sum(int a, int b)=> c = a+b;
    }
    class MyChildClass : MyBaseClass
    {
        int c = 0;
        public override int sum(int a, int b) => c = a + b+100;
    }
    class MethOverriding
    {
        static void Main_01(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyBaseClass b = new MyBaseClass(); //base
            Console.WriteLine(b.sum(3, 2));
            MyBaseClass bc = new MyChildClass();//Child
            Console.WriteLine(bc.sum(5, 2));
            MyChildClass c = new MyChildClass(); //child
            Console.WriteLine(c.sum(30, 2));

        }
    }
}
