Console.WriteLine("Enter the age of the new candidate:");
int age = int.Parse(Console.ReadLine());

if (age < 18)
{
    Console.WriteLine("Too young to apply.");
    Console.WriteLine("Send email to candidate.");
}
else
{
    Console.WriteLine("Great, you can now start with the application.");
}