using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedBrackets.App
{
    public abstract class Helpers
    {
        public static bool AreThereBracketsInString(char[] input)
        {
            if (input.Length == 0)
            {
                return false;
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '{' || input[i] == '(' || input[i] == '[' || input[i] == '}' || input[i] == ')' || input[i] == ']')
                {
                    return true;
                }
            }

            return false;
        }

        public static bool AreBracketsBalanced(char[] input)
        {
            Stack<char> openingBrackets = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '{' || input[i] == '(' || input[i] == '[')
                {
                    openingBrackets.Push(input[i]);
                }

                if (input[i] == '}' || input[i] == ')' || input[i] == ']')
                {
                    if (openingBrackets.Count == 0)
                    {
                        return false;
                    }

                    else if (!ArePairsEqual(openingBrackets.Pop(), input[i]))
                    {
                        return false;
                    }
                }
            }

            if (openingBrackets.Count == 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        private static bool ArePairsEqual(char openingBracket, char closingBracket)
        {
            if (openingBracket == '(' && closingBracket == ')')
            {
                return true;
            }
            else if (openingBracket == '{' && closingBracket == '}')
            {
                return true;
            }
            else if (openingBracket == '[' && closingBracket == ']')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
