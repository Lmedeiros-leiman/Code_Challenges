public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false ;
        int[] store = new int [26];
        foreach(char c in s){
            store[c-'a']++;
        }
        foreach(char c in t){
            if(store[c -'a']> 0){
                store[c - 'a']--;
            }else{
                return false ;
            }
        }
        return true;
    }
}