<?php
/*
The sum of the squares of the first ten natural numbers is,

12 + 22 + ... + 102 = 385
The square of the sum of the first ten natural numbers is,

(1 + 2 + ... + 10)2 = 552 = 3025
Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.

Find the difference between the sum of the squares of the first n natural numbers and the square of the sum.
*/

define('EXPONENT' , 2);

function SumOfTheGauss($lastNumber){

// Gauss sum formula: S = (n * (n + 1)) / 2
    return ( $lastNumber * ($lastNumber + 1 ) ) / 2;
}

function SumOfTheSquares($n){

    $result = 0;

    for ( $number = 1 ; $number <= $n ; $number++ ) { 
        $result += pow( $number , EXPONENT );
    }

    return $result;
}

function SquareOfTheSum($n) {

    $finalSum = SumOfTheGauss($n);
    $finalResult = pow( $finalSum , EXPONENT );

    return $finalResult;
}




function SumSquareDifference($n) {
    
    $sumOfTheSquares = SumOfTheSquares($n);
    $squareOfTheSum = SquareOfTheSum($n);
    
    return $squareOfTheSum - $sumOfTheSquares;
}



//Tests

echo SumSquareDifference(10)."\n";
echo SumSquareDifference(20)."\n";
echo SumSquareDifference(100)."\n";
