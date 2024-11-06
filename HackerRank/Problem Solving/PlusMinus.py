#!/bin/python3

import math
import os
import random
import re
import sys

#
# Complete the 'plusMinus' function below.
#
# The function accepts INTEGER_ARRAY arr as parameter.
#

def plusMinus(arr):
    # Write your code here
    negCount = 0
    zeroCount = 0
    posCount = 0
    for n in arr:
        if n < 0:
            negCount += 1
        elif n > 0:
            posCount += 1
        else:
            zeroCount += 1
    
    print( posCount / len(arr) )
    print( negCount / len(arr) )
    print( zeroCount / len(arr))

    return [negCount, posCount, zeroCount]


if __name__ == '__main__':
    n = int(input().strip())
    arr = list(map(int, input().rstrip().split()))
    plusMinus(arr)

