
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
         
            Console.WriteLine(language); // Compile Time Error since 
            //Internal cannot be accessible to outside assembly
        }
    }


    public class AssemblyOneClass2
    {
        public void SomeClass2()
        {
            Class1 obj = new Class1();
            Console.WriteLine(obj.language); // Compile Time Error since 
            //Internal cannot be accessible to outside assembl
        }
    }
}
