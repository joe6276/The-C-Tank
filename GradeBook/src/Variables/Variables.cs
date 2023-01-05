using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Variables
{
    public class Variables
    {
         static int age;

    int y = 100;

    const int tax = 16;
    readonly string password;
    public Variables(int fory)
    {
        age = 100;
        y=fory;
        password = "12345678";
    }

    static void Main(string[] args)
    {
        Console.WriteLine(age);
        myClass();
        var  objy = new Variables(14);
        Console.WriteLine(objy.y);
    }

    public static void myClass()
    {
        int x = 100;
        Console.WriteLine(x);
    }
    }
}

// in the case of a static variable  we have one coppy irrespective of how many copies of objects we create , static will always override is
//a new value is reassigned in the constructor.

//For non static the variables are different for each copy of an object , its lifetime depends on he lofetime of an object

//for constant , a Variable and the value of the constant variable cant be modified after declaration.

//For readonly the value can only be modified within a constructor  if not assigned during initialization.
