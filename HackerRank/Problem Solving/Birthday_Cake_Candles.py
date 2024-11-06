#!/bin/python3

import math
import os
import random
import re
import sys

#
# Complete the 'birthdayCakeCandles' function below.
#
# The function is expected to return an INTEGER.
# The function accepts INTEGER_ARRAY candles as parameter.
#

def birthdayCakeCandles(candles : list[int]) -> int:
   # Write your code here
   counts = {}
   tallest = 0
   for candle in candles:
      if candle > tallest:
         tallest = candle

      
      if (counts.get(candle)):
         counts[candle] += 1
      else:
         counts[candle] = 1

   return counts.get(tallest, 0)

if __name__ == '__main__':
   fptr = open(os.environ['OUTPUT_PATH'], 'w')

   candles_count = int(input().strip())

   candles = list(map(int, input().rstrip().split()))

   result = birthdayCakeCandles(candles)

   fptr.write(str(result) + '\n')

   fptr.close()
