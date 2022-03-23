

namespace CodeWars_Playground
{
    public static class SquareRoot
    {
        public static bool IsSquare(int n)
        {
            float sqrt = MathF.Sqrt(n);
            return sqrt == MathF.Floor(sqrt);
        }
    }
}
