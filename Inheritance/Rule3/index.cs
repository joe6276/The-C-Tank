//We can Initialize a Parent class variable by using the child class instance 
//to make it a reference variable so that the reference  will be consuming the
// memory of the child class instance. But in this case, also, we cannot
//call any pure child class members using the reference.
using System;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            A obja;
            B objb = new B();
            obja = objb;
            obja.method1();
            obja.method2();

            obja.method3(); // This leads to compile time Error because 

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


