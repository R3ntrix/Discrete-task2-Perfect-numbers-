
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Enter the start of the range: ");
var rangeStart = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the end of the range: ");
var rangeEnd = int.Parse(Console.ReadLine());

Console.WriteLine("Perfect numbers between {0} and {1} are: ", rangeStart, rangeEnd);

// Methods
static bool IsAPerfectNumber(int number)
{
    if (number < 6) { return false; } // since the least perfect number is 6

    int remainder, total = 0;

    for (int i = 1; i < number; i++)
    {
        remainder = number % i;
        if (remainder == 0)
        {
            total += i;
        }

    }

    bool isPerfectNumber = total == number? true : false;
    return isPerfectNumber;
}

// Loop
int numberOfPerfectNumbers = 0;
for (int i = rangeStart; i <= rangeEnd; i++)
{

    bool isPerfect = IsAPerfectNumber(i);
    if (isPerfect)
    {
        Console.WriteLine(i);
        numberOfPerfectNumbers++;
    }
}

if (numberOfPerfectNumbers > 0)
{
    Console.WriteLine("Number of perfect numbers found in the given range: " + numberOfPerfectNumbers);
}
else
{
    Console.WriteLine("No perfect numbers were found in the given range! ");
}