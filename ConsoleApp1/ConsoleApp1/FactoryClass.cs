using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    // Static class can not have instance Constructors
    static class FactoryClass
    {
        public static void Display() => Console.WriteLine("In Factory Class");
    }
    class B
    {

    }
    class CMainFactory
    {
        static void Main_06(string[] args)
        {
        }
    } 
}
