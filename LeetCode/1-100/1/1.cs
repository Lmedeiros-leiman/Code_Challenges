public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // solution tatic: hashMap/array.
        Dictionary<int,int> indices = new();

        for (int index = 0; index < nums.Count(); index++) {
            var number = nums[index];
            var difference = target - number;

            if (indices.ContainsKey(difference)) {
                return new int[] {indices[difference], index};
            }
            indices[number] = index;
        }
        return [];
    }
}