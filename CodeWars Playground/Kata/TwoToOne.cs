// Take 2 strings, s1 and s2, including only letters from a to z.
// Return a new sorted string, containing only distinct letters from s1 and s2.

namespace CodeWars_Playground.Kata
{
    public static class TwoToOne
    {
        public static string Longest(string s1, string s2)
        {
            var result = new string ((s1 + s2).Distinct()
                                              .OrderBy(x => x)
                                              .ToArray());

            return result;
        }

        public static void Test()
        {
            Console.WriteLine(Longest("isadufbaslkdfjb", "sdfuiohssgrez"));
        }
    }
}
