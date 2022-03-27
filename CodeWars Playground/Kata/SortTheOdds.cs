using CodeWars_Playground;
/*Task
 * You will be given an array of numbers. You have to sort the odd numbers in ascending order while leaving the even numbers at their original positions.
 * Examples
 * [7, 1]  =>  [1, 7]
 * [5, 8, 6, 3, 4]  =>  [3, 8, 6, 5, 4]
 * [9, 8, 7, 6, 5, 4, 3, 2, 1, 0]  =>  [1, 8, 3, 6, 5, 4, 7, 2, 9, 0]
 */

namespace CodeWars_Playground.Kata
{
    public static class SortTheOdds
    {
        public static int[] SortArray(int[] array)
        {
            var odds = array.Where(x => x % 2 != 0);
            var sortedOdds = new Queue<int>(odds.OrderBy(x => x).ToArray());

            for (int i = 0; i < array.Length; i++)
                if (array[i] % 2 != 0) array[i] = sortedOdds.Dequeue();

            return array;
        }

        public static void Test()
        {
            HelperFunctions.PrintArray(SortArray(new [] { 9, 8, 7, 6, 5, 4, 3, 2, 1 }));
        }
    }
}
