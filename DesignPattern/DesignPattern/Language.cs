using System;

namespace DesignPattern
{
    interface ILanguage //:ILang,IType
    {
        string getParadigm();
        string getUnit();
        string getName();

    }
    //interface IType
    //{
    //    string getParadigm();
    //    string getUnit();
    //}
    public abstract class Procedural:ILanguage//IType
    {
        public abstract string getName();
        public string getParadigm() => "Procedure";
        public string getUnit() => "Func";
    }
    public abstract class ObjectOriented:ILanguage//:IType
    {
        public abstract string getName();
        public string getParadigm() => "OOPS";
        public string getUnit() => "Class";
    }
    public class LangC : Procedural
    {
        public override string getName() => "C";
        public void display() { }        
    }
    public class LangJava : ObjectOriented
    {
        public override string getName() => "Java";
    }
    public class LangCpp
    {
        //public override string getName() => "C++";
    }
    class Language 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ILanguage c = new LangC() ;
            Console.WriteLine(c.getName());
            Console.WriteLine(c.getParadigm());
            Console.WriteLine(c.getUnit());
        }
    }
}
