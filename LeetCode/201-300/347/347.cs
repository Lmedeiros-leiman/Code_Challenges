using System;
using System.Collections.Generic;
using System.Globalization;
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

        // organize the dictionary values into an decrecending order
        // its possible to use the dictionary built in OrderByDescending method...
        // but realistically that would be cheating and an intervewer would ask HOW it works.
        // The PriorityQueue sorts our array by making a heap (a tree of the elements) giving eachone a "priority" (deph inside the tree)
        // we simply insert content and remove if its size is above K, making so that only the highest values are kept in storage.

        var Queue = new PriorityQueue<int,int>();
        foreach(var key in elementsFrequency.Keys) {
            Queue.Enqueue(key, elementsFrequency[key]);
            if (Queue.Count > k) Queue.Dequeue(); // we make sure the queue is aways of size K (if possible)
        }
        // and then we transform it into an array since thats our data type.
        // we insert into it in REVERSE ORDER because the heap stores from smallest value to highest.

        int index = k;
        while (Queue.Count > 0) // we empty the queue
        {
            index--;
            requestedElements[index] = Queue.Dequeue();
            
        }
        return requestedElements;
    }

}