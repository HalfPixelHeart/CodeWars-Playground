using System.Collections.Generic;
using System.Linq;

/*
There is a bus moving in the city, and it takes and drop some people in each bus stop.
You are provided with a list (or array) of integer pairs.
Elements of each pair represent number of people get into bus (The first item) and number of people get off the bus (The second item) in a bus stop.
Your task is to return number of people who are still in the bus after the last bus station (after the last array).
Even though it is the last bus stop, the bus is not empty and some people are still in the bus, and they are probably sleeping there :D

Take a look on the test cases.
Please keep in mind that the test cases ensure that the number of people in the bus is always >= 0. So the return integer can't be negative.
The second value in the first integer array is 0, since the bus is empty in the first bus stop.
*/

namespace CodeWars_Playground.Kata
{
    public static class Bus
    {
        public static int Number(List<int[]> peopleListInOut)
        {
            var peopleIn = peopleListInOut.Select(x => x[0]).Sum();
            var peopleOut = peopleListInOut.Select(x => x[1]).Sum();

            return peopleIn - peopleOut;
        }

        public static void Test()
        {
            List<int[]> peopleList = new List<int[]>() { new[] { 10, 0 }, new[] { 3, 5 }, new[] { 5, 8 } };
            Console.WriteLine(Number(peopleList));
        }
    }
}
