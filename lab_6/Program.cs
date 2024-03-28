using System;
using System.Collections.Generic;
using System.Linq;

public static class MyExtension
{
    // Extension method to calculate sum of digits of an integer
    public static int SummaDigit(this int number)
    {
        int sum = 0;
        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }

    // Extension method to calculate sum of original number and its reverse
    public static uint SummaWithReverse(this uint number)
    {
        uint reversedNumber = 0;
        uint originalNumber = number;
        while (number > 0)
        {
            reversedNumber = reversedNumber * 10 + number % 10;
            number /= 10;
        }
        return originalNumber + reversedNumber;
    }

    // Extension method to count non-letter characters in a string
    public static int CountNotLetter(this string str)
    {
        return str.Count(c => !char.IsLetter(c));
    }

    // Extension method to check if a DayOfWeek is a weekend
    public static bool IsDayOff(this DayOfWeek dayOfWeek)
    {
        return dayOfWeek == DayOfWeek.Saturday || dayOfWeek == DayOfWeek.Sunday;
    }

    // Extension method to filter even positive elements from a collection of integers
    public static IEnumerable<int> EvenPositiveElements(this IEnumerable<int> collection)
    {
        return collection.Where(num => num > 0 && num % 2 == 0);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Example usage of extension methods
        int number = 1274;
        Console.WriteLine("Sum of digits of " + number + ": " + number.SummaDigit());

        uint numberToReverse = 132;
        Console.WriteLine("Sum of " + numberToReverse + " and its reverse: " + numberToReverse.SummaWithReverse());

        string str = "I like C#";
        Console.WriteLine("Number of non-letter characters in \"" + str + "\": " + str.CountNotLetter());

        DayOfWeek day = DayOfWeek.Sunday;
        Console.WriteLine(day + " is a weekend: " + day.IsDayOff());

        int[] array = { 2, -2, 3, 4, 0, 6, 1, 9 };
        Console.WriteLine("Even positive elements in array: " + string.Join(", ", array.EvenPositiveElements()));

        List<int> list = new List<int> { 2, 3, -4, 8, 5, 4 };
        Console.WriteLine("Even positive elements in list: " + string.Join(", ", list.EvenPositiveElements()));
    }
}
