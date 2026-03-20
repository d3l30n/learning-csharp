using System;

class composite_formatting
{

    static void Main()
    {
        //Composite Formatting in C# is a feature that lets you insert values into a string using placeholders like {0}, {1}, which are replaced by provided arguments (e.g., Console.WriteLine("Result: {0}", x);).

        int num = 10;
        string name = "John Doe";
        string name2 = "Jane Doe";

        Console.Write("{1} was married to {2} for long {0} years.", num, name, name2);



    }

}