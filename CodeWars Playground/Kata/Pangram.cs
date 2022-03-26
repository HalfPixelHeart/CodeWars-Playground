﻿// A pangram is a sentence that contains every single letter of the alphabet at least once.
// For example, the sentence "The quick brown fox jumps over the lazy dog" is a pangram, because it uses the letters A-Z at least once (case is irrelevant).
// Given a string, detect whether or not it is a pangram.
// Return True if it is, False if not. Ignore numbers and punctuation.

namespace CodeWars_Playground.Kata
{
    public static class Pangram
    {
        public static bool IsPangram(string str)
        {
            var alphabetHash = new HashSet<char>("abcdefghijklmnopqrstuvwxyz");
            var strHash = new HashSet<char>(str.ToLowerInvariant());

            alphabetHash.IntersectWith(strHash);

            return alphabetHash.Count == 26;
        }

        public static void Test()
        {
            IsPangram("This is not a pangram23423");
            IsPangram("The quick brown fox jumps over the lazy dog!234");
        }
    }
}
