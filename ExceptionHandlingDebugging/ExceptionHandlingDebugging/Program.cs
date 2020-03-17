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
        // Console will run this first sequence

        static void StartSequence()
        {
            try
            {
                Console.WriteLine("Enter a number greater than zero");

                string userInput = Console.ReadLine();
                int convertedInput = Convert.ToInt32(userInput);

                int[] array = new int[convertedInput];

                // Passing the array as an argument for Populate
                int[] arr = Populate(array);

                // Passing the arr from Populate as an argument for GetSum
                int sum = GetSum(arr);

                // Passing the sum as an argument for GetProduct
                int product = GetProduct(arr, sum);

                // Passing the product as an argument for GetQuotient
                decimal quotient = GetQuotient(product);

                Console.WriteLine($"Your array size is {array.Length}");
                Console.WriteLine("Your number in array are [{0}]", string.Join(", ", arr));
                Console.WriteLine($"Your sum of the array is {sum}");
                Console.WriteLine($"{sum} * {product/sum} = {product}");
                Console.WriteLine($"{product} / {product/quotient} = {quotient}");
                Console.WriteLine("Program is Complete.");
                Console.ReadLine();

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

        // Populating the Array
        static int[] Populate(int[] pop)
        {

            for (int i = 0; i < pop.Length; i++)
            {
                Console.WriteLine($"Enter a number, {i+1} of {pop.Length}");

                string userInput = Console.ReadLine();
                int userInt = Convert.ToInt32(userInput);
                pop[i] = userInt;
            }
            return pop;
        }

        // Getting the sum of Array
        static int GetSum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
             sum += arr[i];
            }
            if(sum < 20)
            {
                    Console.WriteLine($"Value of {sum} is too low.");
            }
            return sum;
        }

        // Get the multiplication product of chosen number and sum
        static int GetProduct(int[] Get, int sum)
        {
            try
            {
                Console.WriteLine($"enter a number between 1 and {Get.Length}:");
                string randomNumber = Console.ReadLine();
                int userNum = Convert.ToInt32(randomNumber);

                var product = sum * Get[userNum-1];

                return product;

            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Error message : {ex.Message}");
                throw;
            }

        }

        //Get division product
        static decimal GetQuotient(int product)
        {
            try
            {
                Console.WriteLine($"Enter a number to divide your product of {product} by:");
                string input = Console.ReadLine();

                int userNum = Convert.ToInt32(input);

                decimal quotient = decimal.Divide(product, userNum);
                return quotient;

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error message : {ex.Message}");
                return 0;
            }
        }
    }
}
