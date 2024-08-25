using System;
using System.Collections.Generic;
using System.Linq;
using Internal;

public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        int[] requestedElements = new int[k];

        Dictionary<int,int> elementsFrequency = new();

        // fill up the dictionary/hashTable
        foreach(int number in nums) {
            if ( elementsFrequency.ContainsKey(number) ) {
                elementsFrequency[number]++;
            } else {
                elementsFrequency.Add(number, 1);
            }
        }
        elementsFrequency.OrderByDescending();

        // organize the dictionary values into an decrecending order
        // its possible to use the dictionary built in OrderByDescending method...
        // but realistically that would be cheating and an intervewer would ask HOW it works.
        
        // The sorting algorith would be something similar to enumerating the dictionary/Hashset
        // push numbers if theres an empty space, otherwise CHECK the final list to see where to put the incoming number.
        
        // PiorityQueue from C# could do it easily but i want to showcase the code working.

        

        foreach (int Key in elementsFrequency.Keys) {
            AddDigitsAndSort();
        }




        return requestedElements;
    }

    public Array<T> AddDigitsAndSort(var newElement, int arraySizeLimit) {

        return new int[];
    }

}

/*
*       # Program Logic
*   Basically we put all the numbers trough a hashset where the index is the number and the value is how many times it appears on the original array.
*   I'M using a dictionary because i like the extra abstraction.
*   
*   Then we create an array with the 
*/