using System;
using System.Collections.Generic;

/*
By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
What is the nth prime number?
*/

internal class Program
{
    public static bool IsPrime(int number)
    {
        int rootOfValue = (int)Math.Sqrt(number);

        for (int valueOfRange = 2; valueOfRange <= rootOfValue; valueOfRange++)
        {
            if (number % valueOfRange == 0)
            {
                return false;
            }
        }
        return true;
    }

    public static List<int> GeneratePrimesUpTo(int value)
    {
        var allPrimes = new List<int>();
        int countPrimes = value;
        int countNumbers = 2;

        while (countPrimes > 0)
        {
            if (IsPrime(countNumbers))
            {
                allPrimes.Add(countNumbers);
                countPrimes--;
            }

            countNumbers++;
        }

        return allPrimes;
    }



    public static int NthPrime(int n)
    {
        var primes = GeneratePrimesUpTo(n);

        return primes[n - 1];
    }


    /*Tests*/
    public static void Main()
    {
        Console.WriteLine(NthPrime(6));
        Console.WriteLine(NthPrime(10));
        Console.WriteLine(NthPrime(100));
        Console.WriteLine(NthPrime(1000));
        Console.WriteLine(NthPrime(1001));
    }
}