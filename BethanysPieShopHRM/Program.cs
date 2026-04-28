/*
 * While loop example
 */

/*
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

*/

bool isExitSelected = false;

while (!isExitSelected)
{
    Console.WriteLine("Select an option from the menu:");
    Console.WriteLine("1. Add a new customer");
    Console.WriteLine("2. Update a customer");
    Console.WriteLine("3. Delete a customer");
    Console.WriteLine("4. View all customers");
    Console.WriteLine("5. Exit");
    string selectedOption = Console.ReadLine();
    switch (selectedOption)
    {
        case "1":
            Console.WriteLine("Adding a new customer (not implemented yet)");
            break;
        case "2":
            Console.WriteLine("Updating a customer (not implemented yet)");
            break;
        case "3":
            Console.WriteLine("Deleting a customer (not implemented yet)");
            break;
        case "4":
            Console.WriteLine("Viewing all customers (not implemented yet)");
            break;
        default:
            Console.WriteLine("Quiting.");
            isExitSelected = true;
            break;
    }
}
