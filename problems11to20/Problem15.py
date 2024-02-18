"""
Starting in the top left corner of a 2X2 grid, and only being able to move to the right and down, there are exactly 6 routes to the bottom right corner.

a diagram of 6 2 by 2 grids showing all the routes to the bottom right corner
How many such routes are there through a given gridSize?

"""

def Factorial(number):
    if number == 1:
        return 1
    return number * Factorial(number - 1)


def Combinatorics(numberTotalELements, numberElementsSelected):
    # this formula is fundamental in combinatorics, which is the branch of mathematics that deals with counting, ordering and combining objects or elements.
    
    numerator = Factorial(numberTotalELements + numberElementsSelected)
    denominator = Factorial(numberElementsSelected) * Factorial(numberTotalELements)
    
    return numerator / denominator
    
    
    
def LatticePaths(gridSize):
    # For a grid of size (n x m), the number of possible paths is given by combinations (n + m, n) or (n + m, m)
    return Combinatorics(gridSize, gridSize)



#tests

print(LatticePaths(4))
print(LatticePaths(9))
print(LatticePaths(20))
