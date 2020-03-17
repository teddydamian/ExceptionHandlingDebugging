using System;

namespace ExceptionHandlingDebugging
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my game! Let's do some math!");
            try
            {
                StartSequence();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong!");
            }

        }
        static void StartSequence()
        {
            try
            {
                Console.WriteLine("Enter a number greater than zero");
                int userInput = Convert.ToInt32(Console.ReadLine());
                int[] array = new int[userInput];
                Populate(array);
                GetSum(array);
                GetProduct(array, GetSum(array));
                GetQuotient(GetProduct);
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"You have a Format Exception of :{ex}");

            }
            catch (OverflowException exx)
            {
                Console.WriteLine($"You have a Overflow Exception of :{exx}");

            }

        }
        static int[] Populate(int[] pop)
        {

        }
    }
}
