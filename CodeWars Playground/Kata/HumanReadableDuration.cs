using System.Collections.Generic;

namespace CodeWars_Playground.Kata
{
    public enum Period { year = 31536000, day = 86400, hour = 3600, minute = 60, second = 1 }

    public static class HumanReadableDuration
    {
        public static string formatDuration(int seconds)
        {
            if (seconds == 0) return "now";

            var periods = new Stack<string>();
            var delimiters = new Stack<string>(new string[] { ", ", ", ", ", ", " and ", ""});
            var output = "";

            periods.TryPush(Period.year.FormatPeriod(ref seconds));
            periods.TryPush(Period.day.FormatPeriod(ref seconds));
            periods.TryPush(Period.hour.FormatPeriod(ref seconds));
            periods.TryPush(Period.minute.FormatPeriod(ref seconds));
            periods.TryPush(Period.second.FormatPeriod(ref seconds));

            while (periods.Count > 0) output = periods.Pop() + delimiters.Pop() + output;

            return output;
        }

        private static string FormatPeriod(this Period period, ref int seconds)
        {
            var count = seconds / (int)period;
            seconds %= (int)period;

            return count == 0 ? "" : $"{count} {period}" + (count > 1 ? "s" : "");
        }

        private static void TryPush(this Stack<string> stack, string period)
        {
            if (period != "") stack.Push(period);
        }
    }
}
