public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> numList = new HashSet<int>();

        for (int index = 0; index < nums.Count(); index++) {
            if (numList.Contains(nums[index])) { return true;}
            numList.Add(nums[index]);
        }

        return false;

    }
}
