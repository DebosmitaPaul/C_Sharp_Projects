using System;
using System.Collections;
using System.Text;

namespace ConsoleApp1
{
    class HashtableClass
    {
        static void Main(string[] args)
        {
            //similar to generic Dictionary collection
            //Key and value can be of any data type. Key cannot be null whereas value can be null.
            Hashtable ht = new Hashtable()
                {
                    { 1, "One" },
                    { 2, "Two" },
                    { 3, "Three" },
                    { 4, "Four" },
                    { 5, null },
                    { "Fv", "Five" },
                    { 8.5F, 8.5 }
                };

            string strValue1 = (string)ht[2];
            string strValue2 = (string)ht["Fv"];
            float fValue = (float)ht[8.5F];

            Console.WriteLine(strValue1);
            Console.WriteLine(strValue2);
            Console.WriteLine(fValue);
        }
    }
}
