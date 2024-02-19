<?php
/*
2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.

What is the sum of the digits of the number 2^exponent?
*/

function ArrayOfDigits($base,$exponent)
{
    return bcpow($base, $exponent);
}

function PowerDigitSum($exponent) {

    $sum = 0;
    $digits = ArrayOfDigits(2,$exponent);

    for ( $position = 0 ; $position < strlen($digits) ; $position++ ) { 
        
        $sum += intval( $digits[ $position ] );
    }

    return $sum;
}

  
echo PowerDigitSum(15)."\n";
echo PowerDigitSum(128)."\n";
echo PowerDigitSum(1000)."\n";