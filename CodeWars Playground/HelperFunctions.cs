using System.Diagnostics;

namespace CodeWars_Playground
{
    public static class HelperFunctions
    {
        public static void PrintArray<T>(T[] arr) => Console.WriteLine(string.Join(',', arr));
        public static void PrintList<T>(List<T> list)
        {
            foreach(var item in list) Console.Write(item.ToString() + " ");
        }

        public static void DisplayElapsed(this Stopwatch stopwatch)
        {
            TimeSpan ts = stopwatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);

            Console.WriteLine("Elapsed Time: " + elapsedTime);
        }
    }
}
