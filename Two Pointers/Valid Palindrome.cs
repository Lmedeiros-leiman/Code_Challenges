
public class Solution
{
    public bool IsPalindrome(string s)
    {
        int start = 0;
        int end = s.Count() - 1;

        while (start < end)
        {
            if (!Char.IsLetterOrDigit(s[start])) { start++; }
            else if (!Char.IsLetterOrDigit(s[end])) { end--; }
            else
            {
                if (char.ToLower(s[start]) != char.ToLower(s[end]))
                {
                    return false;
                }

                start++;
                end--;
            }


        }

        return true;
    }
}
