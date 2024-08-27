using System.Collections.Generic;

public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] resultArray = new int[nums.Length];
        Dictionary<int, int> productsDictionary = new();

        for (int index = 0; index < nums.Length; index++) {
            int resultProduct = 1;

            if (productsDictionary.ContainsKey(nums[index])) {
                resultProduct = productsDictionary[nums[index]];
            }
            else {

                for (int j = 0; j < nums.Length; j++) {
                    if (j == index) { continue; }
                    resultProduct *= nums[j];
                }
                productsDictionary[nums[index]] = resultProduct;
            }

            resultArray[index] = resultProduct;
        }
        return resultArray;
    }
}

// O(1) space complexity
// O(n2) speed complexity
public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] resultArray = new int[nums.Length];

        int lastProduct = 0;
        int lastNumber = 0;
        for (int index = 0; index < nums.Length; index++) {
            resultArray[index] = 1;

            if (nums[index] == lastNumber) {
                resultArray[index] = lastProduct;
            }
            else {
                for (int j = 0; j < nums.Length; j++) {
                    if (j == index) { continue; }
                    resultArray[index] *= nums[j];
                }
            }
            lastProduct = resultArray[index];
            lastNumber = nums[index];
        }
        return resultArray;
    }
}

// Youtube Tutorial
//
public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] resultArray = new int[nums.Length];
        int aux = 1;

        for (int i = 0; i < nums.Length; i++) {
            resultArray[i] = aux;
            aux *= nums[i];
        }

        aux = 1;
        for (int i = nums.Length-1; i <= 0; i--) {
            resultArray[i] *= aux;
            aux *= nums[i];
        }
        return resultArray;
    }
}
//
// 2    3  4   5
// 2    6  24  120
// 120  60 20  5
//


