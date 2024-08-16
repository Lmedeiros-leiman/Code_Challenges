public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> numDict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];
            if (numDict.ContainsKey(complement)) {
                return new int[] { numDict[complement], i };
            }
            if (!numDict.ContainsKey(nums[i])) {
                numDict.Add(nums[i], i);
            }
        }
        throw new ArgumentException("No two sum solution");
    }
}