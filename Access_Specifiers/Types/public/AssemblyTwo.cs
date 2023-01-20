namespace AssembyTwo
{
    public class Class1
    {
        internal protected  string language = "Dotnet";

        public void Display1()
        {
            Console.WriteLine(language);
        }
    }

    public class Class2 : Class1
    {
        public void Display2()
        {
            Console.WriteLine(language); 
        }
    }


    public class Class3
    {
        public void Display2()
        {
            Class1 object1 = new Class1();
            Console.WriteLine(object1.language);
        }
    }
}