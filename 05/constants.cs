using System;

class constants
{

    static void Main()
    {
        //negative testing on constant variables
        const string song = "It was a bad idea";
        const string song1 = "I can't get enough";

        Console.WriteLine("{0} \n To think I could stop \n Was such a bad idea \n {1}", song, song1);
        //below theres an intentional error (since constant variables cannot have their value changed after the first assignment)
        //string song = "whatever";

        //Console.WriteLine("{0}\n Needing you so late \n Was such a bad idea \n 'Cause I can't think straight", song);

    }



}