using CodeWars_Playground;
using System.Linq;

/*
 * Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.
 * Kata.MoveZeroes(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1}) => new int[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0}
 */

namespace CodeWars_Playground.Kata
{
    public static class MovingZeroes
    {
        public static int[] MoveZeroes(int[] arr)
        {
            var numbers = arr.Where(x => x != 0);
            var zeroes = arr.Where(x => x == 0);
            var result = numbers.Concat(zeroes).ToArray();
            return result;

            // Can also be performed in one line:
            // return arr.Where(x => x != 0).Concat(arr.Where(x => x == 0)).ToArray();
        }

        public static int[] MoveZeroesOneLine(int[] arr)
        {
            return arr.Where(x => x != 0).Concat(arr.Where(x => x == 0)).ToArray();
        }

        public static void Test()
        {
            var testInput = new int[] { 1, 3, 3, 4, 6, 2, 3, 0, 4, 3, 0, 5, 0, 8, 0, 0, 9 };
            Console.WriteLine("MoveZeroes");
            HelperFunctions.PrintArray(MoveZeroes(testInput));
            Console.WriteLine("MoveZeroesOneLine");
            HelperFunctions.PrintArray(MoveZeroesOneLine(testInput));
        }
    }
}
