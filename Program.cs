using System;

namespace Abstraction
{
    abstract class BaseClass
    {
        public abstract void Method();
        public abstract string Property { get; }
        public abstract string this[int index] { get; }
    }

    class DerivedClass : BaseClass
    {
        public override void Method() => Console.WriteLine("DerivedClass.Method");
        public override string Property => "DerivedClass.Property";
        public override string this[int index] => "DerivedClass.Indexer";
    }

    class Program
    {
        static void Main()
        {
            DerivedClass derivedInstance = new DerivedClass();
            derivedInstance.Method();
            Console.WriteLine(derivedInstance.Property);
            Console.WriteLine(derivedInstance[0]);
        }
    }
}
