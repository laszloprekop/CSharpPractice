// See https://aka.ms/new-console-template for more information

using TutorialTopLevelStatements;

// Console.WriteLine();
/*
// Respond as Strings of arguments

foreach (var s in args)
{
    Console.WriteLine(s);
    Console.WriteLine(' ');
}
Console.WriteLine();

*/
/*
// Respond with a random answer

string[] answers = [ "Yes", "No", "Maybe" ];

var index = new Random().Next(answers.Length);
Console.WriteLine(answers[index]);
*/

// testing out some ASCII animation
using System.Threading.Tasks;

await Utilities.ShowProgressAnimation();

string[] answers = ["This is positive", "This is negative", "Rather not tell", "You tell me"];

var index = new Random().Next(answers.Length);
Console.WriteLine(answers[index]);