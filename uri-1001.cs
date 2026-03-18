namespace learning_csharp;

public class Program
{
  
  public static void Main()
  { 
    int  n1, n2, sum;
   Console.WriteLine("First number:");
   n1 = Convert.ToInt32(Console.ReadLine());

   Console.WriteLine("Second number:");
   n2 = Convert.ToInt32(Console.ReadLine());

   sum = n1 + n2;

   Console.WriteLine("The sum of these two numbers is " + sum);

  }



}
