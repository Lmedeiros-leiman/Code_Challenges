// https://www.codewars.com/kata/51b6249c4612257ac0000005/train/csharp

using System;
using System.Collections.Generic;



public class RomanDecode
{
    public static int Solution(string roman)
    {
        // assume-se que a string de numerais romanos é válida.
        // 
        int result = 0;
        Stack<char> romanStack = new();
        Dictionary<char, int> romanDictionary = new Dictionary<char, int>
        {
            ['M'] = 1000,
            ['D'] = 500,
            ['C'] = 100,
            ['L'] = 50,
            ['X'] = 10,
            ['V'] = 5,
            ['I'] = 1,
        };


        foreach (char c in roman)
        {
            int currentNumber = romanDictionary[c];

            if (romanStack.Count > 0)
            {
                char lastChar = romanStack.Peek();
                int lastNumber = romanDictionary[lastChar];

                if (lastNumber < currentNumber)
                {
                    result -= lastNumber * 2;
                    //romanStack.Pop();
                }
            }

            result += currentNumber;
            romanStack.Push(c);
        }

        return result;
    }
}