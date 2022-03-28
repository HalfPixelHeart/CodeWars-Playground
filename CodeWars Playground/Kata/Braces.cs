using System.Collections.Generic;

namespace CodeWars_Playground.Kata
{
    public static class Braces
    {
        static Dictionary<char, char> pairs = new Dictionary<char, char>()
        {
            {'(' , ')' },
            {'[' , ']' },
            {'{' , '}' }
        };

        public static bool validBraces(string braces)
        {
            var stack = new Stack<char>();

            foreach (char c in braces)
            {
                if (pairs.ContainsKey(c))
                    stack.Push(c);

                if (pairs.ContainsValue(c))
                {
                    if (stack.Count == 0) return false;
                    if (c != pairs[stack.Peek()]) return false;

                    stack.Pop();
                }
            }

            return stack.Count == 0;
        }

        public static void Test()
        {
            Console.WriteLine($"() = {validBraces("()")}");
            Console.WriteLine($"(){{}}[] = {validBraces("(){}[]")}");
            Console.WriteLine($"([{{}}]) = {validBraces("([{}])")}");
            Console.WriteLine($"(}} = {validBraces("(}")}");
            Console.WriteLine($"[(]) = {validBraces("[(])")}");
            Console.WriteLine($"[({{}})](] = {validBraces("[({})](]")}");
        }
    }
}
