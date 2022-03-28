
/* Implement the function unique_in_order which takes as argument a sequence
 * and returns a list of items without any elements with the same value next to each other
 * and preserving the original order of elements.
 * 
 * For example:
 * uniqueInOrder("AAAABBBCCDAABBB") == {'A', 'B', 'C', 'D', 'A', 'B'}
 * uniqueInOrder("ABBCcAD")         == {'A', 'B', 'C', 'c', 'A', 'D'}
 * uniqueInOrder([1,2,2,3,3])       == {1,2,3}
 */

namespace CodeWars_Playground.Kata
{
    public static class UniqueOrdered
    {
        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            var result = new Stack<T>();
            T lastAdded;

            foreach(var item in iterable)
            {
                if (!result.TryPeek(out lastAdded))
                {
                    result.Push(item);
                    continue;
                }

                if (!item.Equals(lastAdded)) result.Push(item);
            }

            return result.Reverse();
        }

        public static void Test()
        {
            Console.WriteLine("Testing: AAAABBBCCDAABBB");

            foreach(var item in UniqueInOrder("AAAABBBCCDAABBB"))
            {
                Console.WriteLine(item);
            }
        }
    }
}
