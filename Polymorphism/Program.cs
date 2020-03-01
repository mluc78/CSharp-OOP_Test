using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperClass x = new SubClass_1();
            SuperClass y = new SubClass_2();

            //Instance of any subclass can be store in references of the superclass
            //Also the correct instance implementations are called

            x.Method(); //Output: Called from the first subclass
            y.Method(); //Output: Calles from the second subclass
        }
    }

    public class SuperClass
    {
        public virtual void Method()
            => Console.WriteLine("Called from supper-class");
    }

    public class SubClass_1 : SuperClass
    {
        public override void Method()
            => Console.WriteLine("Called from the first subclass");
    }

    public class SubClass_2 : SuperClass
    {
        public override void Method()
            => Console.WriteLine("Called from the second subclass");
    }
}
