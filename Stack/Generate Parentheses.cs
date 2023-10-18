// https://leetcode.com/problems/generate-parentheses/
using System.Collections.Generic;
using System.Text;

public class Solution
{
    public IList<string> GenerateParenthesis(int n)
    {
        //
        // a ideia é criar uma função recursiva.
        // começara com "("
        // só ira colocar outros "(" se o numero open for menor que n
        // só ira colocar ")" se o numero de open for maior que closed
        // irá quebrar a recursão quando open == closed == n
        //

        List<string> result = new(); // este é nosso stack.
        StringBuilder seq = new();

        void backtrack(int open, int close)
        {
            if (seq.Length == n * 2 /* 2 pois (( + )) | básicamente open == closed == n */)
            {
                result.Add(seq.ToString());
                return;
            }

            if (open < n)
            {
                seq.Append("(");
                backtrack(open + 1, close);
                seq.Remove(seq.Length - 1, 1);
            }
            if (close < open)
            {
                seq.Append(")");
                backtrack(open, close + 1);
                seq.Remove(seq.Length - 1, 1);
            }
        }
        backtrack(0, 0);
        return result;

    }
}
