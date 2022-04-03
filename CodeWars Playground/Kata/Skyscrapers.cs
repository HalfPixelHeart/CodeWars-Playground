

namespace CodeWars_Playground.Kata
{
    public class Skyscrapers
    {

    }

    public struct VantagePoint
    {
        public int[] View = new int[4];
        public int MaxVisibility;
        public int Visibility
        {

        }

        public VantagePoint(int[] view, int maxVisibility)
        {
            view.CopyTo(View, 0);
            MaxVisibility = maxVisibility;
        }


    }

}
