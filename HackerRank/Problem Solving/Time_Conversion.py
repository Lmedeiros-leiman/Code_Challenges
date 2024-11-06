#!/bin/python3

import math
import os
import random
import re
import sys

#
# Complete the 'timeConversion' function below.
#
# The function is expected to return a STRING.
# The function accepts STRING s as parameter.
#
# Input is a string that follows the format: "hh:mm:ssAM" or "hh:mm:ssPM"
#

def timeConversion(s):
   # Write your code here
   numbers = s.split(":")
   
   if ( numbers[-1][-2:] == "PM"):
      if ( int(numbers[0]) == 12):
         pass
      else:
         numbers[0] = str( int(numbers[0] ) + 12 )
      #s[:2] = str( int(s[:2]) + 12 )
   else:
      if ( int(numbers[0]) == 12):
         numbers[0] =  "00"


   numbers[-1] = numbers[-1][:-2]
   
   return ":".join(numbers)

if __name__ == '__main__':
    print(timeConversion("12:05:45AM"))
    pass
    
    fptr = open(os.environ['OUTPUT_PATH'], 'w')
    s = input()
    result = timeConversion(s)
    fptr.write(result + '\n')
    fptr.close()
