Console.WriteLine("Enter the age of the new candidate:");
int age = int.Parse(Console.ReadLine());


/*

if (age < 18)
{
    Console.WriteLine("Too young to apply.");
    Console.WriteLine("Send email to candidate.");
}
else if (age > 65)
{
    Console.WriteLine("Too old to apply.");
    Console.WriteLine("Send email to candidate.");
}
{
    Console.WriteLine("Great, you can now start with the application.");
}

 */

switch (age)
{
    case < 18:
        Console.WriteLine("Too young to apply.");
        break;
    case > 65:
        Console.WriteLine("Too old to apply.");
        break;
    case 23:
        Console.WriteLine("You are 23 years old. You can start with the application right now.");
        break;
    default:
        Console.WriteLine("Great, you can now start with the application.");
        break;
}