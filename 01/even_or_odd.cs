namespace learning_csharp
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("== Even or Odd Number Checker ==");
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            int result = number % 2;

            if(result == 0)
            {
                Console.WriteLine("The number entered is Even!");
            }
              else
                {
                  Console.WriteLine("The number entered is Odd!");
                }   
        }
    }
}    