DateTime hireDate = new DateTime(2026, 2, 20, 16, 2, 0);

Console.WriteLine(hireDate);

DateTime exitDate = new DateTime(2026, 4, 27, 16, 20, 0);

TimeSpan workPeriod = exitDate - hireDate;
Console.WriteLine($"Days: {workPeriod.Days}");
Console.WriteLine($"Total Days: {workPeriod.TotalDays}");

Console.WriteLine($"Start date: {hireDate.ToLongDateString()}");
Console.WriteLine($"End date: {exitDate.ToShortDateString()}");
Console.WriteLine($"End time: {exitDate.ToShortTimeString()}");

int numberOfHoursStudied = 11;

long veryLongDay = numberOfHoursStudied;

double d = 123456789.0;
int x = (int)d; // explicitly cast to int

int intVeryLongDay = (int)veryLongDay;

Console.WriteLine($"A very long day as an integer: {intVeryLongDay}");

Console.ReadLine();

/*
 * Explicit typing: You explicitly declare the type of the variable
 */

int k = 123;
bool l = true;
double m = 11.2;

/*
 * Implicit typing: C# figures out the type of the variable based on the value assigned to it.
 */

var n = 123; // n will be an integer
var o = false; // o will be a bool
var p = 11.31415; // p will be a double  