
/* Your task is to construct a building which will be a pile of n cubes.
 * The cube at the bottom will have a volume of n^3, the cube above will have volume of (n-1)^3 and so on until the top which will have a volume of 1^3.
 * You are given the total volume m of the building. Being given m can you find the number n of cubes you will have to build?
 * 
 * Examples:
 * findNb(1071225) --> 45
 * findNb(91716553919377) --> -1
 */

namespace CodeWars_Playground.Kata
{
    public static class PileOfCubes
    {
        public static long findNb(long m)
        {
            var cubes = 0;

            while (m > 0) m -= (long)Math.Pow(++cubes, 3);

            return m == 0 ? cubes : -1;
        }
    }
}
