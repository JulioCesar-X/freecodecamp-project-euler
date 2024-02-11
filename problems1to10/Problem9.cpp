/*
A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,

a^2 + b^2 = c^2
For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.

There exists exactly one Pythagorean triplet for which a + b + c = 1000. Find the product abc such that a + b + c = n.
*/

#include <iostream>
#include <cmath>

using namespace std;

bool IsPythagoreanTriplet(int sideA, int sideB, int hypotenuse) {

    return ( sideA < sideB && sideB < hypotenuse ) && ( pow( sideA, 2 ) + pow( sideB, 2 ) == pow( hypotenuse, 2 ) );
}

int SpecialPythagoreanTriplet(int n) {

    int hypotenuse;

    for ( int sideA = 1 ; sideA < n ; sideA++ ) {

        for ( int sideB = sideA + 1 ; sideB < n ; sideB++ ) {

            hypotenuse = sqrt( pow( sideA, 2) + pow( sideB, 2) );
        
            if ( IsPythagoreanTriplet( sideA, sideB, hypotenuse ) && sideA + sideB + hypotenuse == n ) {

                return sideA * sideB * hypotenuse;
            }
        }
    }
    
}

// Tests
int main() {

    cout << SpecialPythagoreanTriplet(24) << endl;
    cout << SpecialPythagoreanTriplet(120) << endl;
    cout << SpecialPythagoreanTriplet(1000) << endl;

    return 0;
}

