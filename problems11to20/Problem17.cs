/*
If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.

If all the numbers from 1 to given limit inclusive were written out in words, how many letters would be used?

Note: Do not count spaces or hyphens. For example, 342 (three hundred and forty-two) contains 23 letters and 115 (one hundred and fifteen) contains 20 letters. The use of "and" when writing out numbers is in compliance with British usage.
*/

using System;
internal class Program
{

    public static int countLettersInNumber(int number)
    {
        switch (number)
        {
            case 1:
                return 3;
            case 2:
                return 3;
            case 3:
                return 5;
            case 4:
                return 4;
            case 5:
                return 4;
            case 6:
                return 3;
            case 7:
                return 5;
            case 8:
                return 5;
            case 9:
                return 4;
            case 10:
                return 3;
            case 11:
                return 6;
            case 12:
                return 6;
            case 13:
                return 8;
            case 14:
                return 8;
            case 15:
                return 7;
            case 16:
                return 7;
            case 17:
                return 9;
            case 18:
                return 9;
            case 19:
                return 8;
            case 20:
                return 6;
            case 30:
                return 6;
            case 40:
                return 5;
            case 50:
                return 5;
            case 60:
                return 5;
            case 70:
                return 7;
            case 80:
                return 6;
            case 90:
                return 6;
            case 100:
                return 10;
            case 1000:
                return 8;
                
            default:

                if (number < 100)
                {

                    int tens = (number / 10) * 10;
                    int units = number % 10;
                    return countLettersInNumber(tens) + countLettersInNumber(units);
                }
                else
                {

                    int hundreds = number / 100;
                    int remainder = number % 100;
                    if (remainder == 0)
                    {
                        return countLettersInNumber(hundreds) + 7;
                    }
                    else
                    {
                        return countLettersInNumber(hundreds) + 10 + countLettersInNumber(remainder);
                    }
                }
        }
    }
    public static int NumberLetterCounts(int limit)
    {

        int totalLetters = 0;

        for (int number = 1; number <= limit; number++)
        {
            totalLetters += countLettersInNumber(number);
        }

        return totalLetters;
    }

    /*Tests*/
    public static void Main()
    {
        Console.WriteLine(NumberLetterCounts(1000));
        Console.WriteLine(NumberLetterCounts(5));
        Console.WriteLine(NumberLetterCounts(167));
        Console.WriteLine(NumberLetterCounts(374));
        Console.WriteLine(NumberLetterCounts(500));
    }

}