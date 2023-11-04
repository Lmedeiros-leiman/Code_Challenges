// https://leetcode.com/problems/longest-substrnewing-without-repeating-characters/
// no final hashmap ajuda com tudo \o/
namespace Solution;


public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        /* minha solução
        if (s.Length < 2) { return s.Length; }
        
        HashSet<char> hSet = new HashSet<char>();
        int max = 0;
        int i = 0;
        int j = 0;
        
        while(i<s.Length)
        {
        char c = s[i];
            if(!hSet.Contains(c))
            {
                hSet.Add(c);
                i++;
            }
            else
            {
                max = Math.Max(max,hSet.Count);
                hSet.Remove(s[j]);
                j++;
            }
        }
        return = Math.Max(max,hSet.Count);
        
        */
        
        // código mais rápido enviado:
        
        if (s.Length < 2) { return s.Length; }
        
        var hs = new Dictionary<char, int>();
        int result = 0;
        int right = 0; // equivalente ao i;
        int left = 0; // equivalente ao j;
        


        while (right < s.Length)
        {
            char c = s[right];

            hs[c] = hs.TryGetValue(c, out int value) ? value + 1 : 1;
            while (hs[c] > 1)
            {
                // procura pela duplicata.
                hs[s[left]]--;
                left++;
            }

            result = Math.Max(result, right - left + 1);
            right++;
            
        }

        return result;
    }
}




