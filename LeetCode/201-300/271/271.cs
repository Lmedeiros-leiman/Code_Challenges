using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Internal;

public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder encodedString = new();
        
        foreach(string s in strs) {
            encodedString.Append(s.Length +'$'+ s);
        }
        
        return encodedString.ToString();
    }
    
    public List<string> Decode(string s) {
        List<string> decodedString = new();

        
        int index = 0;
        while(index < s.Length) {
            int j = index;
            while ( s[j] != "$" ) { j++; }

            //
            int wordSize = Int32.Parse(s.Substring(index,j-i) );
            j++;
            string word = s.Substring[j - index,wordSize];
            decodedString.Append(word);
            
            //
            index = j + wordSize;
        }

        return decodedString;
    }
}