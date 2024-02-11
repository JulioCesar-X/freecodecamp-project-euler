
<?php

/*
If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
Find the sum of all the multiples of 3 or 5 below the provided parameter value number.
*/

function SumMultiplesOf3Or5( $lastNumberOfRange ) {
    
    $sumRangeOfMultiples = 0;

    for ( $indexOfrange = 1 ; $indexOfrange < $lastNumberOfRange ; $indexOfrange++ ) {
        
        if ($indexOfrange % 3 == 0 || $indexOfrange % 5 == 0) {
            $sumRangeOfMultiples += $indexOfrange;
        }

    }
    
    return $sumRangeOfMultiples;

}

/*Tests */
echo SumMultiplesOf3Or5(10)."\n";
echo SumMultiplesOf3Or5(49)."\n";
echo SumMultiplesOf3Or5(1000)."\n";
echo SumMultiplesOf3Or5(8456)."\n";
echo SumMultiplesOf3Or5(19564)."\n";
