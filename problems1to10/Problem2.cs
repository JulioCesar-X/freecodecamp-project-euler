using System;
using System.Collections.Generic;

/*
Problem 2: Even Fibonacci Numbers Each new term in the Fibonacci sequence is generated by adding the previous two terms. 
By starting with 1 and 2, the first 10 terms will be: 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
By considering the terms in the Fibonacci sequence whose values do not exceed n, find the sum of the even-valued terms.
*/
internal class Program
{
     public static int FiboEvenSum(int lastFiboNumber)
    {

     int firstFiboNumber = 1;
     int secondFiboNumber = 1;

     int nextFiboNumber = firstFiboNumber + secondFiboNumber;
     int sumOfEven = 0;

     while (nextFiboNumber <= lastFiboNumber){
         
         if (nextFiboNumber % 2 == 0){

             sumOfEven += nextFiboNumber;
         }

         firstFiboNumber = secondFiboNumber;
         secondFiboNumber = nextFiboNumber;
         nextFiboNumber = firstFiboNumber + secondFiboNumber;

     }

     return sumOfEven;

    }

    /*Tests*/
    public static void Main(){

        Console.WriteLine(FiboEvenSum(10));
        Console.WriteLine(FiboEvenSum(8));
        Console.WriteLine(FiboEvenSum(34));
        Console.WriteLine(FiboEvenSum(60));
        Console.WriteLine(FiboEvenSum(1000));
        Console.WriteLine(FiboEvenSum(100000));
        Console.WriteLine(FiboEvenSum(4000000));

    }


}