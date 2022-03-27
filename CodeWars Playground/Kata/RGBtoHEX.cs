
/*The rgb function is incomplete. Complete it so that passing in RGB decimal values will result in a hexadecimal representation being returned. Valid decimal values for RGB are 0 - 255. Any values that fall out of that range must be rounded to the closest valid value.
 * Note: Your answer should always be 6 characters long, the shorthand with 3 will not work here.
 * The following are examples of expected output values:
 * 
 * Rgb(255, 255, 255) # returns FFFFFF
 * Rgb(255, 255, 300) # returns FFFFFF
 * Rgb(0,0,0) # returns 000000
 * Rgb(148, 0, 211) # returns 9400D3
 */

namespace CodeWars_Playground.Kata
{
    public static class RGBtoHEX
    {
        public static string RGB(int r, int g, int b) => ToHex(r) + ToHex(g) + ToHex(b);
        private static string ToHex(int i) => Math.Clamp(i, 0, 255).ToString("X2");

        public static void Test()
        {
            Console.WriteLine(RGBtoHEX.RGB(255, 255, 255));
            Console.WriteLine(RGBtoHEX.RGB(300, -98, 12));
        }






        static Dictionary<int, string> HexValues = new Dictionary<int, string>()
        {
            { 10, "A" },
            { 11, "B" },
            { 12, "C" },
            { 13, "D" },
            { 14, "E" },
            { 15, "F" }
        };
        private static string HEX(int i)
        {
            i = Math.Clamp(i, 0, 255);

            var char1 = GetHexValue((int)MathF.Floor(i / 16));
            var char2 = GetHexValue(i % 16);

            return char1 + char2;
        }
        private static string GetHexValue(int i) => i < 10 ? i.ToString() : HexValues[i];

    }
}
