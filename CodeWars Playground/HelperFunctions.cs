
namespace CodeWars_Playground
{
    public static class HelperFunctions
    {
        public static void PrintArray<T>(T[] arr) => Console.WriteLine(string.Join(',', arr));
        public static void PrintList<T>(List<T> list)
        {
            foreach(var item in list) Console.WriteLine(item.ToString());
        }
    }
}
