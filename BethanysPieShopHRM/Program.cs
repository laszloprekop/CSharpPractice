/*
 * Console menu using switch statement
 */
 
 Console.WriteLine("Choose the action you want to perform:");
 Console.WriteLine("1. Add a new employee");
 Console.WriteLine("2. Update employee information");
 Console.WriteLine("3. Remove an employee");
 
 string selectedOption = Console.ReadLine();

 switch (selectedOption)
 {
    case "1":
       Console.WriteLine("Adding new employee (Placeholder message)");
        break;
    case "2":
       Console.WriteLine("Updating employee information (Placeholder message)");
       break;
    case "3":
       Console.WriteLine("Removing employee (Placeholder message)");
       break;
    default:
       Console.WriteLine("Invalid option");
       break;
 }