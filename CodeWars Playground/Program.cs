// See https://aka.ms/new-console-template for more information
using CodeWars_Playground.Kata;
using CodeWars_Playground;

string observed = "84585285";
Console.WriteLine("ALTERNATE PINS");
Console.WriteLine($"PIN observed: {observed}");

ObservedPIN.GetPINs(observed);
// Console.WriteLine("Possible alternatives: \n");
// HelperFunctions.PrintList(ObservedPIN.GetPINs(observed));