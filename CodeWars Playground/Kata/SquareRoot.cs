namespace CodeWars_Playground.Kata
{
    public static class SquareRoot
    {
        public static bool IsSquare(int n) => MathF.Sqrt(n) % 1 == 0;
    }
}
