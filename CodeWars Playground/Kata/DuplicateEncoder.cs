using System.Linq;
using CodeWars_Playground;
/*
 * The goal of this exercise is to convert a string to a new string where each character in the new string is "(" if that character appears only once in the original string,
 * or ")" if that character appears more than once in the original string.
 * Ignore capitalization when determining if a character is a duplicate.
 * Examples
 * "din"      =>  "((("
 * "recede"   =>  "()()()"
 * "Success"  =>  ")())())"
 * "(( @"     =>  "))((" 
 * Notes
 * Assertion messages may be unclear about what they display in some languages. If you read "...It Should encode XXX", the "XXX" is the expected result, not the input!
 */

namespace CodeWars_Playground.Kata
{
    public static class DuplicateEncoder
    {
        public static string DuplicateEncode(string word)
        {
            var lowerWord = word.ToLowerInvariant();
            var charArray = lowerWord.ToCharArray();

            var result = lowerWord.Select(x => Array.FindAll(charArray, y => y == x).Count() > 1 ? ')' : '(');

            return new string(result.ToArray());

            // return new string(word.ToLowerInvariant().Select(x => Array.FindAll(word.ToLowerInvariant().ToCharArray(), y => y == x).Count() > 1 ? ')' : '(').ToArray());
        }

        public static void Test()
        {
            Console.WriteLine(DuplicateEncode("din"));
            Console.WriteLine(DuplicateEncode("recede"));
        }
    }
}
