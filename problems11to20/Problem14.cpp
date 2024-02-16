/*
The following iterative sequence is defined for the set of positive integers:

n → n/2 (n is even)
n → 3n + 1 (n is odd)
Using the rule above and starting with 13, we generate the following sequence:

13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.

Which starting number, under the given limit, produces the longest chain?

Note: Once the chain starts the terms are allowed to go above limit.
*/

#include <iostream>

using namespace std;

int GenerateCollatzSequence(int newLimit) {

    int count = 1;

    while (newLimit != 1) 
    {
        if (newLimit % 2 == 0) 
        {
            newLimit /= 2;
        }
        else 
        {
            newLimit = 3 * newLimit + 1;
        }

        count++;
    }

    return count;
}


int LongestCollatzSequence(int limit) {

    int maxCount = 0;
    int startingNumber = 0;

    for (int numberBellowTheLimit = 1; numberBellowTheLimit <= limit; numberBellowTheLimit++) 
    {
        int count = GenerateCollatzSequence(numberBellowTheLimit);

        if (count > maxCount)
        {
            maxCount = count;
            startingNumber = numberBellowTheLimit;
        }
    }

    return startingNumber;
}



// Tests
int main() {

    cout << LongestCollatzSequence(14) << endl;
    cout << LongestCollatzSequence(5847) << endl;
    cout << LongestCollatzSequence(46500) << endl;
    cout << LongestCollatzSequence(54512) << endl;
    cout << LongestCollatzSequence(100000) << endl;
    cout << LongestCollatzSequence(1000000) << endl;

    return 0;
}