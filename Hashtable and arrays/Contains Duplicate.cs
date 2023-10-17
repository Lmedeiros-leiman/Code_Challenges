// https://leetcode.com/problems/contains-duplicate/

namespace COntainsDUplicate;

public static class Solution {
    public static bool ContainsDuplicate(int[] nums) {

        HashSet<int> hashmap = new();

        foreach(int x in nums) 
        {
            if (hashmap.Contains(x)) 
            {
                return true;
            }
            hashmap.Add(x);
        }



        return false;    
    }
}