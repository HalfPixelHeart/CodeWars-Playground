using System.Text.RegularExpressions;
using System.Linq;

/*
Complete the solution so that it splits the string into pairs of two characters.
If the string contains an odd number of characters then it should
replace the missing second character of the final pair with an underscore ('_').
Examples:

* 'abc' =>  ['ab', 'c_']
* 'abcdef' => ['ab', 'cd', 'ef']
*/

namespace CodeWars_Playground.Kata
{
    public static class SplitString
    {
        public static string[] Solution(string str)
        {
            Regex rx = new Regex(@".{1,2}");
            var matches = rx.Matches(str);
            var result = matches.Select
                (
                    x => x.Length < 2 ? x.ToString() + "_" : x.ToString()
                ).ToArray();

            return result;
        }

        public static string[] AlternateSolution(string str)
        {
            return Regex.Matches(str + "_", @"w{2}").Select(x => x.Value).ToArray();
        }

        public static void Test()
        {
            Console.WriteLine($"Result of passing abcde: {Solution("abcde")}");
            Console.WriteLine($"Result of passing abcdef: {Solution("abcdef")}");
        }
    }
}
