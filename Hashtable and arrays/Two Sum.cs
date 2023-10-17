
namespace Two_Sum;

public class Solution
{
    public int[] TwoSum(int[] nums, int target) 
    {
        Dictionary<int, int> Indices = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) 
        {
            int diff = target - nums[i];
            if (Indices.ContainsKey(diff)) 
            {
                return new int[] {Indices[diff],i};
            }
            Indices[nums[i]] = i;
        }
        

        return Array.Empty<int>();
    }
}