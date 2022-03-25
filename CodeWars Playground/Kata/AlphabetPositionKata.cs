// In this kata you are required to, given a string, replace every letter with its position in the alphabet.
// If anything in the text isn't a letter, ignore it and don't return it.
// "a" = 1, "b" = 2, etc.

namespace CodeWars_Playground.Kata
{
    public static class AlphabetPositionKata
    {
        static string alphabet = "abcdefghijklmnopqrstuvwxyz";
        static string alphabetPositions = "";

        public static void PrintAlaphabetPositions(string text)
        {
            foreach (char c in text.ToLower())
            {
                if (!alphabet.Contains(c)) continue;
                alphabetPositions += alphabet.IndexOf(c) + 1 + " ";
            }

            alphabetPositions = alphabetPositions.Trim();

            Console.WriteLine(alphabetPositions);
        }
    }
}
