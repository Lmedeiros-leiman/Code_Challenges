// https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/

public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        // ideia simples:
        // como sabemos que o array esta organizado, o maior numero estara no final e o menor no inicio.
        // então só pegarmos a soma e mover os ponteiros conforme a diferença for maior ou menor que o alvo.
        //
        int start = 0;
        int end = numbers.Length - 1;

        while (start < end)
        {
            int sum = numbers[start] + numbers[end];

            if (sum > target)
            {
                end--;
            }
            else if (sum < target)
            {
                start++;
            }
            else
            {
                return new int[] { start + 1, end + 1 };
            }
        }



        return new int[0];
    }
}