using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    /// <summary>
    /// new/virtual-override nei de toh , it will not throw error. Only Compiler error it will give
    /// </summary>
    class BaseClass
    {
        int c = 0;        
        public int sum(int a, int b) => c = a + b;
    }
    class ChildClass : BaseClass
    {
        int c = 0;
        public new int sum(int a, int b) => c = a + b + 100;
    }
    class MethHidding
    {
        static void Main_02(string[] args)
        {
            Console.WriteLine("Hello World!");
            BaseClass b = new BaseClass(); //base
            Console.WriteLine(b.sum(3, 2)); //5
            BaseClass bc = new ChildClass();
            Console.WriteLine(bc.sum(5, 2));//call base sum() method //7
            ChildClass c = new ChildClass();
            Console.WriteLine(c.sum(30, 2)); //132
            
        }
    }
}
