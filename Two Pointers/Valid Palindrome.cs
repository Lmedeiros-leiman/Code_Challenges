

public class Solution
{
    public bool IsPalindrome(string s)
    {
        int start = 0;
        int end = s.Count() - 1;
        s = s.ToLower();
        Console.WriteLine(s);
        for (int i = 0; i < s.Count(); i++)
        {
            if (!Char.IsLetter(s[start])) { start++; continue; }
            if (!Char.IsLetter(s[end])) { end--; continue; }

            if ((s[start]) != (s[end]))
            {
                return false;
            }
            if (start == end) { break; }

            start++;
            end--;
        }

        return true;
    }
}