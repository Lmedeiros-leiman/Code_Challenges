using System.Collections.Generic;
using System.Linq;
using Internal;

public class Solution {
    
    bool isPair(char left, char right) {
        return (
            (left == '(' && right == ')') ||
            (left == '[' && right == ']') ||
            (left == '{' && right == '}')
        );
    }

    
    public bool IsValid(string s) {
        //Dictionary<char,char> charsPairs = new() { {')','('},{']','['},{'}','{'}, };
        Stack<char> stack = new Stack<char>();
        
        foreach(char c in s) {
            if ( c == '(' || c == '[' || c == '{') {
                stack.Push(c);
            } else {
                
                if ( !isPair( stack.Pop(), c  ) ) {
                    return false;
                }

            }
        }

        if (stack.Count > 0) return false;
        return true;
    }
}

