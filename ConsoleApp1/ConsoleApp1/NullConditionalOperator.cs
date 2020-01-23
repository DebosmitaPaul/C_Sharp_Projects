using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class NullConditionalOperator
    {
        static (string, int,double) display(string str, int a, double  d)
        {
            return (str, a, d); //("Debosmita", 1503, 12.34);
        }
        static void Main_04(string[] args)
        {
            Console.WriteLine("Hello World!");
            string person = string.Empty;
            //string firstname = "Debosmita";
            int? len = person?.Length;
            Console.WriteLine(len);

            // Tuples:
            (string a, int b) letters = ("a", 10);
            Console.WriteLine($"{letters.a},{letters.b}");

            // Discards:
            var (s1, _, _) = display("deb", 10, 10.2);
            Console.WriteLine($"string will be {s1} ");
        }
    }
}
