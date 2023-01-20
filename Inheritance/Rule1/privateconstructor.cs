
using System;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            B objectb = new B();
            objectb.method1();
            objectb.method2();
            objectb.method3();
        }
    }

    public class A
    {   

         A()
        {
            Console.WriteLine("The Parent Constructor is Called");
        }
        public void method1()
        {
            Console.WriteLine("Hello from Method One");
        }

        public void method2()
        {
            Console.WriteLine("Hello from Method Two ");
        }
    }

    public class B : A
    {
        public void method3()
        {
            Console.WriteLine("Hello from Method Three ");
        }
    }
}
