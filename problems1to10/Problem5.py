# 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
# What is the smallest positive number that is evenly divisible by all of the numbers from 1 to n?


def mdc(dividend, divisor):
#Calculate the Maximum Common Divisor (MDC) of two numbers using Euclid's algorithm.
    
    while divisor != 0:
        
        dividend, divisor = divisor, dividend % divisor

    return dividend

def mmc(a, b):
#Calculate the Least Common Multiple (LCM) of two numbers using the formula: LCM(x, y) = x * y / GCD(x, y).
     
    return (a * b) // mdc(a, b)

def smallest_mult(n):
    
    result = n
    
    for i in range(2, n + 1):
        
        result = mmc(result, i)
        
    return result




#Tests

print(smallest_mult(5))
print(smallest_mult(7))
print(smallest_mult(10))
print(smallest_mult(13))
print(smallest_mult(20))





