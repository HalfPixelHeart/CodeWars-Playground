using System.Text.RegularExpressions;

/* Complete the solution so that it strips all text that follows any of a set of comment markers passed in.
 * Any whitespace at the end of the line should also be stripped out.
 * Example:
 * 
 * Given an input string of:
 * 
 * apples, pears # and bananas
 * grapes
 * bananas !apples
 * 
 * The output expected would be:
 * 
 * apples, pears
 * grapes
 * bananas
 */

namespace CodeWars_Playground.Kata
{
    public static class CommentStrip
    {
        public static string StripComments(string text, string[] commentSymbols)
        {
            Console.WriteLine($"Input\n{text}\n");

            Console.WriteLine("Comment Symbols");
            foreach(string symbol in commentSymbols) Console.WriteLine(symbol);

            var c = string.Join("", commentSymbols);
            var rx = new Regex($@"(\s+[{c}].+)");
            var output = rx.Replace(text, "");

            Console.WriteLine($"\nOutput\n{output}");

            return output;
        }

        public static void Test()
        {
            var input = "apples, pears # and bananas\ngrapes\nbananas !apples";
            var commentSymbols = new string[] { "#", "!" };
            var output = StripComments(input, commentSymbols);
        }
    }
}
