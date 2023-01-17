
using AssembyTwo;

namespace AccessSpecifierDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class AssemblyOneClass : Class1
    {
        public void SomeClass()
        {
            //You cannot access the Private Member from the Derived Class
            //from Other Assemblies
            Console.WriteLine(language); //Compile Time Error
        }
    }


    public class AssemblyOneClass2
    {
        public void SomeClass2()
        {
            //You cannot access the Private Member from the Non-Derived Classes
            //from Other Assemblies
            Class1 obj = new Class1();
            Console.WriteLine(obj.language); //Compile Time Error
        }
    }
}
