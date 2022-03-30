

namespace CodeWars_Playground.Kata
{
    public class HumanReadableDuration
    {
        public static string formatDuration(int seconds)
        {
            if (seconds == 0) return "now";

            var periods =  new Stack<TimePeriod>();
            var delimiters = new Stack<string>(new string[] { ", ", ", ", ", ", " and ", ""});
            var outputList = new List<string>();
            var output = "";

            if (seconds > 31536000) periods.Push(new TimePeriod("year", 31536000, ref seconds));
            if (seconds > 86400) periods.Push(new TimePeriod("day", 86400, ref seconds));
            if (seconds > 3600) periods.Push(new TimePeriod("hour", 3600, ref seconds));
            if (seconds > 60) periods.Push(new TimePeriod("minute", 60, ref seconds));
            if (seconds > 1) periods.Push(new TimePeriod("second", 1, ref seconds));

            while(periods.Count > 0) output = periods.Pop().formatted + delimiters.Pop() + output;

            return output;
        }

        public struct TimePeriod
        {
            public string name;
            public int secondsInPeriod;
            public int count;
            public string formatted => count == 0 ? "" : count == 1 ? $"1 {name}" : $"{count} {name}s";

            public TimePeriod(string name, int secondsInPeriod, ref int seconds)
            {
                this.name = name;
                this.secondsInPeriod = secondsInPeriod;
                count = seconds / secondsInPeriod;
                seconds %= secondsInPeriod;
            }
        }
    }
}
