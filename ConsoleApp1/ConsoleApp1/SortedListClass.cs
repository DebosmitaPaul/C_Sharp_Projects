using System;
using System.Collections;
using System.Text;

namespace ConsoleApp1
{
    class SortedListClass
    {
        static void Main_10(string[] args)
        {
            //stores key-value pairs in the ascending order of key by default
            SortedList sortedList1 = new SortedList(); //1 2 3 4 5
            sortedList1.Add(3, "Three");
            sortedList1.Add(4, "Four");
            sortedList1.Add(1, "One");
            sortedList1.Add(5, "Five");
            sortedList1.Add(2, "Two");

            SortedList sortedList2 = new SortedList(); // four one three two
            sortedList2.Add("one", 1);
            sortedList2.Add("two", 2);
            sortedList2.Add(3, 3); //Throw error at runtime 
            sortedList2.Add("four", 4);

            SortedList sortedList3 = new SortedList(); // 1.1 1.5 2.3 2.4 3.5
            sortedList3.Add(1.5, 100);
            sortedList3.Add(3.5, 200);
            sortedList3.Add(2.4, 300);
            sortedList3.Add(2.3, null);
            sortedList3.Add(1.1, null);
        }
    }
}
