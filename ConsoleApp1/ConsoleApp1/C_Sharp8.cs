using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //ref struct will not implement IDisposible
    public ref struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        // readonly members
        public readonly double Distance => Math.Sqrt(X * X + Y * Y);
        public readonly override string ToString() => $"({X}, {Y}) is {Distance} from the origin";
    }
    public interface IOrder
    {
        DateTime Purchased { get; }
        decimal Cost { get; }
    }
    public interface ICustomer
    {
        IEnumerable<IOrder> PreviousOrders { get; }
        DateTime DateJoined { get; }
        DateTime? LastOrder { get; }
        string Name { get; }
        IDictionary<DateTime, string> Reminders { get; }
    }
    class CMain_09
    {
        public static int WriteToFile(IEnumerable<string> lines)
        {
            // ** Using keyword before variable 
            using var file = new System.IO.StreamWriter("WriteLines2.txt");
            int skippedLines = 0;
            foreach (string line in lines)
            {
                if (!line.Contains("Second"))
                {
                    file.WriteLine(line);
                }
                else
                {
                    skippedLines++;
                }
            }
            // Notice how skippedLines is in scope here.
            return skippedLines;
            // file is disposed here

            // ** staatic key : ensure that local function doesn't capture (reference) any variables from the enclosing scope.
            static int Add(int a, int b) => a + b;
        }
    }
    public struct Coords<T>
    {
        public T X;
        public T Y;
    }
    class C_Sharp8
    {
        static void Main_09(string[] args)
        {
            string s = "ubethinclient";
            string path = @$"C:\Users\debop\Documents\data\{s}"; // $@ or @$ both are same
            List<int> numbers = null;
            int? i = null;

            numbers ??= new List<int>();
            numbers.Add(i ??= 17); 
            numbers.Add(i ??= 20);

            Console.WriteLine(string.Join(" ", numbers));  // output: 17 17
            Console.WriteLine(i);  // output: 17

            // ** Span: Provides a type- and memory-safe representation of a contiguous region of arbitrary memory
            // ** stackalloc: allocates a block of memory on the stack, during the method execution is automatically discarded when that method returns. 
            //                You cannot explicitly free memory allocated with the stackalloc operator
            //                no subject to garbage collection
            Span<Coords<int>> coordinates = stackalloc[]{
                new Coords<int> { X = 0, Y = 0 },
                new Coords<int> { X = 0, Y = 3 },
                new Coords<int> { X = 4, Y = 0 }
            };
        }
    }
}
