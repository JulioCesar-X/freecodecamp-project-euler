/*
A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
Find the largest palindrome made from the product of two n-digit numbers.
*/

#include <iostream>
#include <string>
#include <cmath>

using namespace std;

bool IsPalindrome(int number) {

    string convertedNumber = to_string(number);
    int lastDigit = convertedNumber.size() - 1;

    for ( int digit = 0 ; digit < lastDigit ; digit++ , lastDigit-- ) {
        if ( convertedNumber[digit] != convertedNumber[lastDigit] ) {

            return false;
        }
    }

    return true;
}

int largestPalindromeProduct(int n) {

    int largestPalindrome = 0;

    int upperLimit = pow( 10, n ) - 1;
    int lowerLimit = pow( 10, n - 1 );

    for ( int firstNumber = upperLimit ; firstNumber >= lowerLimit ; firstNumber-- ) {
        for ( int secondNumber = upperLimit ; secondNumber >= lowerLimit ; secondNumber-- ) {

            int product = firstNumber * secondNumber;

            if ( product > largestPalindrome && IsPalindrome( product ) ) {
                
                largestPalindrome = product;
            }
        }
    }

    return largestPalindrome;
}

// Tests
int main() {

    cout << largestPalindromeProduct(2)<<endl;
    cout << largestPalindromeProduct(3)<<endl;
    cout << largestPalindromeProduct(4)<<endl;

    return 0;
}