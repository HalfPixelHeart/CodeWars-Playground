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
