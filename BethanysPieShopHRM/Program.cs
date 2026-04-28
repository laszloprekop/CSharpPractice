/*
 * While loop example
 */

Console.Write("Enter a value: ");
int max = int.Parse(Console.ReadLine());
int count = 0;
while (count < max)
{
    Console.WriteLine(count);
    count++;
}

Console.WriteLine($"So this is how we reached {max}");


Console.WriteLine("Enter another value:");
int max2 = int.Parse(Console.ReadLine());
int count2 = max2;
while (count2 > 0)
{
    Console.WriteLine(count2);
    count2--;
}

Console.WriteLine($"So this is how we reached 0 from {max2}");