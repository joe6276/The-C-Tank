
// In inheritance, the child class can access the parent class members but 
// the parent classes can never access any members that are purely defined in the child class.
using System;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            A objectb = new A();
            objectb.method1();
            objectb.method2();
            objectb.method3();
        }
    }

    public class A
    {   

        public A()
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
        public B()
        {
            Console.WriteLine("The Child Constructor is Called");
        }
        public void method3()
        {
            Console.WriteLine("Hello from Method Three ");
        }
    }




}