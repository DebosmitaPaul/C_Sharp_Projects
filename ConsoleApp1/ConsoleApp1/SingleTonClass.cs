using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    // unnesery create multiple object for common methoed Display()
    //How to avoid?
    //restrict the instance creation by making ctor as private and also sealed class

        //Only one object will create entire the Application
    sealed class SingleTonClass
    {
        public static int counter = 0;
        private static SingleTonClass Instance = null;
        public static SingleTonClass GetInstance()
        {
            //remove if condition, if 5 object needs to create
            if(Instance == null)
            {
                Instance = new SingleTonClass();
            }
            return Instance;
        }
        
        private SingleTonClass()
        {
            counter++;
            // For more than 5 object created 
            if (counter > 4)
                throw new System.Exception("More than 4 object created");
            Console.WriteLine("Class Constructor. ");
        }
        public void Display()
        {
            Console.WriteLine("Inside Singleton Class display method");
        }
    }
    class CMain
    {
        static void Main_05(string[] args)
        {
            Console.WriteLine("Hello World!");

            SingleTonClass sgObj1 = SingleTonClass.GetInstance();
            Console.WriteLine($"counter for obj1 : {SingleTonClass.counter}");
            sgObj1.Display();
            SingleTonClass sgObj2 = SingleTonClass.GetInstance();
            Console.WriteLine($"counter for obj2: {SingleTonClass.counter}");
            sgObj2.Display();
            SingleTonClass sgObj3 = SingleTonClass.GetInstance();

            SingleTonClass sgObj4 = SingleTonClass.GetInstance();
            SingleTonClass sgObj5 = SingleTonClass.GetInstance();


        }
    }
}
