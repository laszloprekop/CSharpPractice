int age = 25;
const int ageLimit = 25;

bool a = age == ageLimit;
Console.WriteLine($"Age is {ageLimit}: {a}");

bool b = age > 25;
Console.WriteLine($"Age is higher than {ageLimit}: {b}");

bool c = (age >= 18) && (age <= 65);
Console.WriteLine($"Age is between 18 and 65: {c}");

int ageLimitLow = 16;
int agetLimitHigh = 65;

bool isAgeEligible = (age >= ageLimitLow) && (age <= agetLimitHigh);
Console.WriteLine($"Eligible (age is between {ageLimitLow} and {agetLimitHigh}): {isAgeEligible}");
    
bool isAgeNotEligible = (age < ageLimitLow) || (age > agetLimitHigh);
Console.WriteLine($"Not eligible (age is either less than {ageLimitLow} or greater than {agetLimitHigh}): {isAgeNotEligible}");