/*
The prime factors of 13195 are 5, 7, 13 and 29.
What is the largest prime factor of the given number?
*/
function isDivisible(dividend, divisor) {

  return ( dividend % divisor === 0 );
}

function isPrime(number) {

  const rootOfNumber = Math.sqrt(number);

  for ( let possibleDivisor = 2 ; possibleDivisor <= rootOfNumber ; possibleDivisor++ ) {

    if ( isDivisible(number, possibleDivisor) ) {

      return false;
    }
  }

  return true;
}


function largestPrimeFactor(number) {

  const rootOfNumber = Math.sqrt(number);

  if ( isPrime(number) ) {

    return number;
  }

  let largestDivisor = 1;

  for ( let divisor = 2 ; divisor <= rootOfNumber ; divisor++ ) {

    if ( isDivisible(number, divisor) && isPrime(divisor) ) {

      largestDivisor = divisor;
    }
  }

  return largestDivisor;
}


//Tests

  console.log( largestPrimeFactor(2) );
  console.log( largestPrimeFactor(3) );
  console.log( largestPrimeFactor(5) );
  console.log( largestPrimeFactor(7) );
  console.log( largestPrimeFactor(8) );
  console.log( largestPrimeFactor(13195) );
  console.log( largestPrimeFactor(600851475143) );