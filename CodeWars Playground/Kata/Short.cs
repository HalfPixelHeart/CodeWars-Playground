/*
Simple, given a string of words, return the length of the shortest word(s).
String will never be empty and you do not need to account for different data types.
*/

namespace CodeWars_Playground.Kata
{
    public static class Short
    {
        public static int FindShort(string s)
        {
            return s.Split(' ').Min(x => x.Length);
        }

        public static void Test()
        {
            string test = "bitcoin take over the world maybe who knows perhaps";
            Console.WriteLine(FindShort(test));
        }
    }
}
