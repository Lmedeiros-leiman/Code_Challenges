using System.Collections.Generic;
using System.Linq;

public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, IList<string>> anagramGroups = new();

        foreach (string s in strs) {
            char[] hash = new char[26];
            foreach (char c in s) {
                hash[c - 'a']++;
            }

            string organizedString = new string(hash);
            if (!anagramGroups.ContainsKey(organizedString)) {
                anagramGroups[organizedString] = new List<string>();
            }
            anagramGroups[organizedString].Add(s);
        }
        return anagramGroups.Values.ToList();
    }
}
