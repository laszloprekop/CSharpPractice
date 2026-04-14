/*
 * Test cases:
 * 2 3 7 -> 1, Fizz, Buzz, Fizz, 5, FizzBuzz, 7
 * 2 4 7 -> 1, Fizz, 3, FizzBuzz, 5, Fizz, 7
 * 3 5 7 -> 1, 2, Buzz, 4, Buzz, Fizz, 7
 *
 * 1 1 5 -> FizzBuzz, FizzBuzz, FizzBuzz, FizzBuzz, FizzBuzz - always both true
 * 5 7 1 -> 1 - no divisibility
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

Console.Write(string.Join(", ", args));
