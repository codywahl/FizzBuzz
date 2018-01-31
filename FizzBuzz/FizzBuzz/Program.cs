using System;

namespace FizzBuzz
{
    public class Program
    {
        private const string Quit = "q";

        public static void Main(string[] args)
        {
            var firstNumber = GetNumber($" First number ({Quit} to quit): ");
            var secondNumber = GetNumber($"Second number ({Quit} to quit): ");

            for (var i = 1; i <= 100; i++)
            {
                Console.WriteLine(FizzBuzz(firstNumber, secondNumber, i));
            }

            Console.ReadKey();
        }

        private static int GetNumber(string message)
        {
            while (true)
            {
                Console.Write(message);
                var input = Console.ReadLine();

                if (int.TryParse(input, out var value))
                {
                    return value;
                }

                if (input != null && string.Equals(input.ToLower(), Quit))
                {
                    Environment.Exit(1);
                }
            }
        }

        private static string FizzBuzz(int firstNumber, int secondNumber, int i)
        {
            if (i % firstNumber == 0 && i % secondNumber == 0)
                return $"{i} --> FizzBuzz!";

            if (i % firstNumber == 0)
            {
                return $"{i} --> Fizz!";
            }

            return i % secondNumber == 0 ? $"{i} --> Buzz!" : i.ToString();
        }
    }
}