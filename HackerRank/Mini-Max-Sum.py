#!/bin/python3

import math
import os
import random
import re
import sys

#
# Complete the 'miniMaxSum' function below.
#
# The function accepts INTEGER_ARRAY arr as parameter.
#

def miniMaxSum(arr):
   
   arr.sort()

   minSum = 0
   maxSum = 0

   for i in range(len(arr) - 1):
       minSum += arr[i]
       maxSum += arr[len(arr) - i - 1]
   print(str(minSum) + " "+ str(maxSum))
   pass

if __name__ == '__main__':
    arr = list(map(int, input().rstrip().split()))
    miniMaxSum(arr)
