// https://leetcode.com/problems/3sum/

using System;
using System.Collections.Generic;

public class Solution
{
    // a ideia é pegar 3 numeros do array no qual:
    // todos são diferentes um do outro
    // a soma entre os 3 é igual a 0
    //
    // exemplo:
    // 1 + (-3) + 2 = 0
    //
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        IList<IList<int>> result = new();
        int start, end;


        // a ideia do algoritmo é replicar o two sum 2:
        // se utilizarmos o mesmo algoritmo, podemos apenas trocas as condicionais
        // e chegar no resultado esperado.
        Array.Sort(nums);

        for (int i = 0; i < nums.Length; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }
            start = i + 1;
            end = nums.Length - 1;

            while (start < end)
            {
                if (nums[i] + nums[start] + nums[end > 0])
                {
                    end--;
                }
                else if (nums[i] + nums[start] + nums[end < 0])
                {
                    start++;
                }
                else
                {
                    result.Add(new List<int> { nums[i], nums[start], nums[end] });
                    start++;
                    while (nums[start] == nums[start - 1] && start < end)
                    {
                        start++;
                    }
                }
            }
        }

        return new int[0];
    }
}
