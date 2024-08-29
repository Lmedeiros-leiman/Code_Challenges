using System;
using System.Collections.Generic;

public class Solution {
    public int LongestConsecutive(int[] nums) {
        int longest = 0;
        HashSet<int> numbersSet = new HashSet<int>(nums);

        foreach(int n in numbersSet) {
            if (!numbersSet.Contains(n-1)) {
                int length = 0;
                while (numbersSet.Contains(n+length))
                {
                    length++;
                    longest = Math.Max(longest, length);
                }
            }
        }
        return longest;
    }
}