DateTime hireDate = new DateTime(2026, 2, 20, 16, 2, 0);

Console.WriteLine(hireDate);

DateTime exitDate = new DateTime(2026, 4, 27, 16, 20, 0);

TimeSpan workPeriod = exitDate - hireDate;
Console.WriteLine($"Days: {workPeriod.Days}");
Console.WriteLine($"Total Days: {workPeriod.TotalDays}");