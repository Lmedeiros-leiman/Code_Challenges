//https://leetcode.com/problems/valid-anagram/

namespace isAnagram;
public static class Solution {
    public static bool IsAnagram(string s, string t) {

        if (s.Length != t.Length) return false;
        if (s == t) return true;
        
        Dictionary<char, int> smap = new();
        Dictionary<char, int> tmap = new();

        for (int i = 0; i < s.Length; i++)
        {
            smap[s[i]] = 1 + (smap.ContainsKey(s[i]) ? smap[s[i]] : 0);
            tmap[t[i]] = 1 + (tmap.ContainsKey(t[i]) ? tmap[t[i]] : 0);
        }

        foreach (char c in smap.Keys) 
        {
            int tcount = tmap.ContainsKey(c) ? tmap[c] : 0;
            if (smap[c] != tcount) {return false;}
        }
        return true;
    }
}