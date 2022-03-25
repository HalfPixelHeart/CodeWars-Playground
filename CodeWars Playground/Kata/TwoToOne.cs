
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
    }
}
