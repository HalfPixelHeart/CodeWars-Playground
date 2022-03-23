// See https://aka.ms/new-console-template for more information
using CodeWars_Playground;

// Alphabet Positions
string text = "The sunset sets at twelve o' clock.";

AlphabetPositionKata.PrintAlaphabetPositions(text);

// You're a square!
for (int i = -1; i < 26; i++)
{
    Console.WriteLine($"Is {i} a perfect square? {SquareRoot.IsSquare(i)}");
}

