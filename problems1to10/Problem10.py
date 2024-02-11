# The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
# Find the sum of all the primes below n.

from math import sqrt

def is_prime(prime_number):
  
    if prime_number == 1:
        return False
    
    root_prime_number = int(sqrt(prime_number)) + 1
    
    for number in range(2, root_prime_number):
        if prime_number % number == 0:
            return False

    return True

def prime_summation(n):
    
    sum_of_primes = 0
    
    for number in range(2, n):
        if is_prime(number):
            sum_of_primes += number
            
    return sum_of_primes
#Tests

print(prime_summation(17))
print(prime_summation(2001))
print(prime_summation(140759))
print(prime_summation(2000000))

