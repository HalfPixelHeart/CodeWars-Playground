using System.Collections.Generic;

namespace CodeWars_Playground.Kata
{
    public static class Braces
    {
        static Dictionary<char, char> bracePairs = new Dictionary<char, char>()
        {
            {'(' , ')' },
            {'[' , ']' },
            {'{' , '}' }
        };

        public static bool ValidBraces(string braces)
        {
            var braceStack = new Stack<char>();

            foreach (char c in braces)
            {
                if (bracePairs.ContainsKey(c)) braceStack.Push(c);

                if (bracePairs.ContainsValue(c))
                {
                    if (braceStack.Count == 0) return false;
                    if (c == bracePairs[braceStack.Peek()]) braceStack.Pop();
                    else return false;
                }
            }

            return braceStack.Count == 0;
        }

        public static void Test()
        {
            Console.WriteLine($"() = {ValidBraces("()")}");
            Console.WriteLine($"(){{}}[] = {ValidBraces("(){}[]")}");
            Console.WriteLine($"([{{}}]) = {ValidBraces("([{}])")}");
            Console.WriteLine($"(}} = {ValidBraces("(}")}");
            Console.WriteLine($"[(]) = {ValidBraces("[(])")}");
            Console.WriteLine($"[({{}})](] = {ValidBraces("[({})](]")}");
        }
    }
}
