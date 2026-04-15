/*
 * Test cases:
 * 2 3 7 -> 1, Fizz, Buzz, Fizz, 5, FizzBuzz, 7
 * 2 4 7 -> 1, Fizz, 3, FizzBuzz, 5, Fizz, 7
 * 3 5 7 -> 1, 2, Buzz, 4, Buzz, Fizz, 7
 *
 * 1 1 5 -> FizzBuzz, FizzBuzz, FizzBuzz, FizzBuzz, FizzBuzz - always both true
 * 5 7 1 -> 1 - no divisibility
 *
 * assuming running the code with a command similar to the following:
 * > dotnet run --project FizzBuzz -- 2 3 7
 */


/*
 * PSEUDOCODE
 *
 * Read "X Y N" from a single line of input
 *   For each integer I from 1 to N:
 *   if I divisible by both X and Y → print "FizzBuzz"
 *   else if I divisible by X       → print "Fizz"
 *   else if I divisible by Y       → print "Buzz"
 *   else                           → print I
 */


/*
 * Error handling considerations:
 * - Incorrect number of arguments
 * - Non-integer arguments
 * - Invalid values (e.g., zero)
 * - usage hint, example
 */

if (args.Length != 3)
{
    Console.Error.WriteLine($"Error: expected 3 arguments but got {args.Length}.");
    Console.Error.WriteLine("Usage: dotnet run --project FizzBuzz -- <x> <y> <n>");
    Console.Error.WriteLine("  x  first divisor");
    Console.Error.WriteLine("  y  second divisor");
    Console.Error.WriteLine("  n  upper bound (inclusive)");
    return;
}

var (x, y, n) = ParseArgs(args);

Console.Write(string.Join(
    ", ",
    Enumerable.Range(1, n)
        .Select(i => GetResult(x, y, i))));

string GetResult(int firstDivisor, int secondDivisor, int i)
{
    if (i % firstDivisor == 0 && i % secondDivisor == 0) return "FizzBuzz";
    if (i % firstDivisor == 0) return "Fizz";
    if (i % secondDivisor == 0) return "Buzz";
    return i.ToString();
}

(int x, int y, int n) ParseArgs(string[] args) =>
    (ParseArg(args[0], "x"), ParseArg(args[1], "y"), ParseArg(args[2], "n"));

int ParseArg(string value, string name)
{
    if (!int.TryParse(value, out var result) || result <= 0)
    {
        Console.Error.WriteLine($"<{name}> must be a positive integer (got {value})");
        Environment.Exit(1);
    }

    return result;
}