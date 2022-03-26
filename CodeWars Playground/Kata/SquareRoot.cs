// Given an integral number, determine if it's a square number:
// In mathematics, a square number or perfect square is an integer that is the square of an integer; in other words, it is the product of some integer with itself.
// The tests will always use some integral number, so don't worry about that in dynamic typed languages.

namespace CodeWars_Playground.Kata
{
    public static class SquareRoot
    {
        public static bool IsSquare(int n) => MathF.Sqrt(n) % 1 == 0;

        public static void Test()
        {
            for (int i = -1; i < 26; i++)
            {
                Console.WriteLine($"Is {i} a perfect square? {IsSquare(i)}");
            }
        }
    }
}
