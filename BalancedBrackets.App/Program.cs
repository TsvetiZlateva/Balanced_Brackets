using System;

namespace BalancedBrackets.App
{
    class Program
    {
        static void Main(string[] args)
        {
            //Examples:
            //char[] input = { '{', '(', ')', '}', '[', ']' };
            //char[] input = { '(', ')', '}', '[', ']' };

            Console.Write("Please enter input string, or press '.' to EXIT: ");
            char[] input = Console.ReadLine().ToCharArray();

            while (!Helpers.AreThereBracketsInString(input))
            {
                Console.WriteLine("There are no brackets in the input string!");
                Console.Write("Please enter input string, or press '.' to EXIT: ");
                input = Console.ReadLine().ToCharArray();
            }

            while (true)
            {
                if (input.Length == 1 && input[0] == '.')
                {
                    break;
                }

                if (!Helpers.AreThereBracketsInString(input))
                {
                    Console.WriteLine("There are no brackets in the input string!");
                    Console.Write("Please enter input string, or press '.' to EXIT: ");
                    input = Console.ReadLine().ToCharArray();
                    continue;
                }

                string result = Helpers.AreBracketsBalanced(input) ? "Balanced" : "Not Balanced";
                Console.WriteLine(result);

                Console.Write("Please enter input string, or press '.' to EXIT: ");
                input = Console.ReadLine().ToCharArray();
            }
        }
    }
}

