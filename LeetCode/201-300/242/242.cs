public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length ) return false;

        Dictionary<char,int> sMap = new Dictionary<char, int>();
        Dictionary<char,int> tMap = new Dictionary<char, int>();

        for (int index = 0; index < s.Length; index++) {
            sMap[s[index]] = 1 + (sMap.ContainsKey(s[index]) ? sMap[s[index]] : 0);
            tMap[t[index]] = 1 + (tMap.ContainsKey(t[index]) ? tMap[t[index]] : 0);
        }

        foreach (char c in sMap.Keys) {
            int tCount = tMap.ContainsKey(c) ? tMap[c] : 0;
            if (sMap[c] != tCount) return false;
        }
        return true;

    }
}