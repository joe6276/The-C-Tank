// Every class that is defined by us or predefined in the libraries of the language 
// has a default parent class i.e. Object class of the System namespace, so the members
//  (Equals, GetHashCode, GetType, and ToString) of the Object class are accessible from anywhere..

using System;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Object obj = new Object();
            Console.WriteLine($"Object inherits from {obj.GetType()}");

            A objecta = new A();
            Console.WriteLine($" Objecta Inherits from {objecta.GetType()}" );

            B objectb = new B();
            Console.WriteLine($" Objectb inherits from {objectb.GetType()}");




            // We cant call any pure child method using a reference 
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


