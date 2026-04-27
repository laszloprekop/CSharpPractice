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