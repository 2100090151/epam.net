using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // 1) Celsius to Fahrenheit Conversion
        double celsius = 25;
        double fahrenheit = CelsiusToFahrenheit(celsius);
        Console.WriteLine($"1) Celsius to Fahrenheit Conversion: {celsius}°C = {fahrenheit}°F");

        // 2) Sum of Natural Numbers
        int n = 10;
        int sum = SumOfNaturalNumbers(n);
        Console.WriteLine($"2) Sum of Natural Numbers up to {n}: {sum}");

        // 3) Swapping of two numbers
        int a = 5, b = 10;
        Console.WriteLine($"3) Before swapping: a = {a}, b = {b}");
        Swap(ref a, ref b);
        Console.WriteLine($"   After swapping: a = {a}, b = {b}");

        // 4) Armstrong Numbers within Range
        int rangeStart = 100, rangeEnd = 1000;
        Console.WriteLine($"4) Armstrong Numbers within the range {rangeStart} to {rangeEnd}:");
        foreach (var armstrongNumber in ArmstrongNumbersInRange(rangeStart, rangeEnd))
        {
            Console.WriteLine($"   {armstrongNumber}");
        }

        // 5) Fibonacci series
        int fibCount = 10;
        Console.WriteLine($"5) Fibonacci series of {fibCount} numbers:");
        for (int i = 0; i < fibCount; i++)
        {
            Console.Write($"{Fibonacci(i)} ");
        }
        Console.WriteLine();

        // 6) Factorial with and without recursion
        int num = 5;
        Console.WriteLine($"6) Factorial of {num}:");
        Console.WriteLine($"   Without recursion: {FactorialWithoutRecursion(num)}");
        Console.WriteLine($"   With recursion: {FactorialWithRecursion(num)}");

        // 7) Sum of digits of a given N
        int number = 12345;
        Console.WriteLine($"7) Sum of digits of {number}: {SumOfDigits(number)}");

        // 8) Factors of N
        int numberToFactorize = 20;
        Console.WriteLine($"8) Factors of {numberToFactorize}:");
        foreach (var factor in Factors(numberToFactorize))
        {
            Console.Write($"{factor} ");
        }
        Console.WriteLine();

        // 9) Prime or Not
        int primeCheckNumber = 13;
        Console.WriteLine($"9) Is {primeCheckNumber} prime? {IsPrime(primeCheckNumber)}");

        // 10) Palindrome or not
        string palindromeCheckString = "madam";
        Console.WriteLine($"10) Is '{palindromeCheckString}' a palindrome? {IsPalindrome(palindromeCheckString)}");

        // 11) Reverse of a N
        int numberToReverse = 12345;
        Console.WriteLine($"11) Reverse of {numberToReverse}: {ReverseNumber(numberToReverse)}");

        // 12) Leap year or not
        int yearToCheck = 2024;
        Console.WriteLine($"12) Is {yearToCheck} a leap year? {IsLeapYear(yearToCheck)}");

        // 13) Ordering of Array elements
        int[] numbersToOrder = { 5, 2, 7, 1, 8 };
        Console.WriteLine($"13) Ordering of array elements:");
        OrderArray(numbersToOrder);
        foreach (var numberInOrder in numbersToOrder)
        {
            Console.Write($"{numberInOrder} ");
        }
        Console.WriteLine();

        // 14) String reverse
        string stringToReverse = "hello";
        Console.WriteLine($"14) Reverse of '{stringToReverse}': {ReverseString(stringToReverse)}");

        // 15) String palindrome or not
        string stringToCheckPalindrome = "level";
        Console.WriteLine($"15) Is '{stringToCheckPalindrome}' a palindrome? {IsStringPalindrome(stringToCheckPalindrome)}");

        // 16) Count vowels
        string stringToCountVowels = "hello world";
        Console.WriteLine($"16) Number of vowels in '{stringToCountVowels}': {CountVowels(stringToCountVowels)}");

        // 17) Uppercase to Lowercase
        string stringToConvert = "HELLO WORLD";
        Console.WriteLine($"17) Uppercase to lowercase: {ConvertToLowerCase(stringToConvert)}");

        // 18) Frequency of word
        string sentence = "This is a sample sentence is";
        string wordToFindFrequency = "is";
        Console.WriteLine($"18) Frequency of '{wordToFindFrequency}' in the sentence: {WordFrequency(sentence, wordToFindFrequency)}");

        // 19) Number of words
        string sentenceToCountWords = "This is a sample sentence";
        Console.WriteLine($"19) Number of words in '{sentenceToCountWords}': {CountWords(sentenceToCountWords)}");

        // 20) Multiplication table
        int tableOf = 5;
        Console.WriteLine($"20) Multiplication table of {tableOf}:");
        PrintMultiplicationTable(tableOf);

        // 21) ASCII codes
        char charToFindAscii = 'A';
        Console.WriteLine($"21) ASCII code of '{charToFindAscii}': {(int)charToFindAscii}");

        // 22) Nth Fibonacci
        int nthFibonacci = 10;
        Console.WriteLine($"22) {nthFibonacci}th Fibonacci number: {NthFibonacci(nthFibonacci)}");

        // 23) Nth prime
        int nthPrime = 5;
        Console.WriteLine($"23) {nthPrime}th prime number: {NthPrime(nthPrime)}");

        // 24) Patterns with numbers
        int patternRows = 5;
        Console.WriteLine($"24) Pattern with numbers:");
        PrintNumberPattern(patternRows);

        // 25) Patterns with alphabets
        int patternAlphabetRows = 5;
        Console.WriteLine($"25) Pattern with alphabets:");
        PrintAlphabetPattern(patternAlphabetRows);

        // 26) Patterns with *
        int patternStarRows = 5;
        Console.WriteLine($"26) Pattern with '*':");
        PrintStarPattern(patternStarRows);
    }

    // 1) Celsius to Fahrenheit Conversion
    static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    // 2) Sum of Natural Numbers
    static int SumOfNaturalNumbers(int n)
    {
        return n * (n + 1) / 2;
    }

    // 3) Swapping of two numbers
    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    // 4) Armstrong Numbers within Range
    static bool IsArmstrong(int num)
    {
        int originalNum = num;
        int sum = 0;
        int numDigits = num.ToString().Length;

        while (num > 0)
        {
            int digit = num % 10;
            sum += (int)Math.Pow(digit, numDigits);
            num /= 10;
        }

        return sum == originalNum;
    }

    static System.Collections.Generic.IEnumerable<int> ArmstrongNumbersInRange(int start, int end)
    {
        for (int i = start; i <= end; i++)
        {
            if (IsArmstrong(i))
            {
                yield return i;
            }
        }
    }

    // 5) Fibonacci series
    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    // 6) Factorial with and without recursion
    static int FactorialWithoutRecursion(int n)
    {
        int result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }

    static int FactorialWithRecursion(int n)
    {
        if (n == 0)
            return 1;
        return n * FactorialWithRecursion(n - 1);
    }

    // 7) Sum of digits of a given N
    static int SumOfDigits(int n)
    {
        int sum = 0;
        while (n > 0)
        {
            sum += n % 10;
            n /= 10;
        }
        return sum;
    }

    // 8) Factors of N
    static System.Collections.Generic.IEnumerable<int> Factors(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                yield return i;
            }
        }
    }

    // 9) Prime or Not
    static bool IsPrime(int n)
    {
        if (n <= 1)
            return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }

    // 10) Palindrome or not
    static bool IsPalindrome(string str)
    {
        int i = 0, j = str.Length - 1;
        while (i < j)
        {
            if (str[i] != str[j])
                return false;
            i++;
            j--;
        }
        return true;
    }

    // 11) Reverse of a N
    static int ReverseNumber(int n)
    {
        int reversed = 0;
        while (n > 0)
        {
            reversed = (reversed * 10) + (n % 10);
            n /= 10;
        }
        return reversed;
    }

    // 12) Leap year or not
    static bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }

    // 13) Ordering of Array elements
    static void OrderArray<T>(T[] array) where T : IComparable<T>
    {
        Array.Sort(array);
    }

    // 14) String reverse
    static string ReverseString(string str)
    {
        return new string(str.Reverse().ToArray());
    }

    // 15) String palindrome or not
    static bool IsStringPalindrome(string str)
    {
        return IsPalindrome(str);
    }

    // 16) Count vowels
    static int CountVowels(string str)
    {
        return str.Count(c => "AEIOUaeiou".Contains(c));
    }

    // 17) Uppercase to Lowercase
    static string ConvertToLowerCase(string str)
    {
        return str.ToLower();
    }

    // 18) Frequency of word
    static int WordFrequency(string sentence, string word)
    {
        string[] words = sentence.Split(' ');
        return words.Count(w => w.Equals(word, StringComparison.OrdinalIgnoreCase));
    }

    // 19) Number of words
    static int CountWords(string sentence)
    {
        return sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
    }

    // 20) Multiplication table
    static void PrintMultiplicationTable(int n)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{n} * {i} = {n * i}");
        }
    }

    // 21) ASCII codes
    static void AsciiCodes(char c)
    {
        Console.WriteLine($"ASCII code of '{c}' is {(int)c}");
    }

    // 22) Nth Fibonacci
    static int NthFibonacci(int n)
    {
        int a = 0, b = 1;
        for (int i = 2; i <= n; i++)
        {
            int temp = a + b;
            a = b;
            b = temp;
        }
        return b;
    }

    // 23) Nth prime
    static int NthPrime(int n)
    {
        int count = 0;
        int num = 2;
        while (count < n)
        {
            if (IsPrime(num))
            {
                count++;
            }
            num++;
        }
        return num - 1;
    }

    // 24) Patterns with numbers
    static void PrintNumberPattern(int rows)
    {
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }

    // 25) Patterns with alphabets
    static void PrintAlphabetPattern(int rows)
    {
        char startChar = 'A';
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write((char)(startChar + j) + " ");
            }
            Console.WriteLine();
        }
    }

    // 26) Patterns with *
    static void PrintStarPattern(int rows)
    {
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}
