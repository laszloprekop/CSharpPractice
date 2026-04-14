// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

Console.WriteLine();

/*
Display as Strings of arguments

foreach (var s in args)
{
    Console.WriteLine(s);
    Console.WriteLine(' ');
}
Console.WriteLine();

*/

// Display a random answer

string[] answers = [ "Yes", "No", "Maybe" ];

var index = new Random().Next(answers.Length-1);
Console.WriteLine(answers[index]);