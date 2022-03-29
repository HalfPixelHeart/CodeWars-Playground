
/*
Alright, detective, one of our colleagues successfully observed our target person, Robby the robber.
We followed him to a secret warehouse, where we assume to find all the stolen stuff.
The door to this warehouse is secured by an electronic combination lock.
Unfortunately our spy isn't sure about the PIN he saw, when Robby entered it.

The keypad has the following layout:

┌───┬───┬───┐
│ 1 │ 2 │ 3 │
├───┼───┼───┤
│ 4 │ 5 │ 6 │
├───┼───┼───┤
│ 7 │ 8 │ 9 │
└───┼───┼───┘
    │ 0 │
    └───┘
He noted the PIN 1357, but he also said, it is possible that each of the digits he saw
could actually be another adjacent digit (horizontally or vertically, but not diagonally).
E.g.instead of the 1 it could also be the 2 or 4. And instead of the 5 it could also be the 2, 4, 6 or 8.

He also mentioned, he knows this kind of locks.
You can enter an unlimited amount of wrong PINs, they never finally lock the system or sound the alarm.
That's why we can try out all possible variations:
    the observed PIN itself and all variations considering the adjacent digits.

Can you help us to find all those variations?
It would be nice to have a function, that returns an array (or a list in Java/Kotlin and C#
of all variations for an observed PIN with a length of 1 to 8 digits.
We could name the function getPINs (get_pins in python, GetPINs in C#).
But please note that all PINs, the observed one and also the results, must be strings,
because of potentially leading '0's. We already prepared some test cases for you.

Detective, we are counting on you!
*/


namespace CodeWars_Playground.Kata
{
    public static class ObservedPIN
    {
        private static Dictionary<string, List<string>> keyVariations = new Dictionary<string, List<string>>()
        {
            {"1", new List<string> { "1","2","4"} },
            {"2", new List<string> { "1","2","3","5"} },
            {"3", new List<string> { "2","3","6"} },
            {"4", new List<string> { "1","4","5","7"} },
            {"5", new List<string> { "2","4","5","6","8"} },
            {"6", new List<string> { "3","5","6","9"} },
            {"7", new List<string> { "4","7","8"} },
            {"8", new List<string> { "5","7","8","9","0"} },
            {"9", new List<string> { "6","8","9"} },
            {"0", new List<string> { "8","0"} }
        };
        public static List<string> GetPINs(string observed)
        {
            var pins = new List<string>() { "" };

            foreach (var key in observed)
            {
                pins = CrossJoin(pins, keyVariations[key.ToString()]);
            }

            return pins;
        }

        public static List<string> CrossJoin(List<string> left, List<string> right)
        {
            var join = from x in left
                       from y in right
                       select x + y;

            return join.ToList();
        }
    }
}
