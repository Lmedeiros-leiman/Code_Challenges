// https://leetcode.com/problems/daily-temperatures/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Daily_Temperatures;

public class Solution
{
    public int[] DailyTemperatures(int[] temperatures)
    {
        // passar pelas temperaturas e validar se a temperatura seguinte é mais quente.
        int[temperatures.Length] result;
        Array.Fill(result, 0);
        Stack<int> temperatureStack = new();

        for (int i = 0; i < temperatures.Length; i++)
        {
            int t = temperatures[i];

            while (temperatureStack.Any() && temperatures[temperatureStack.Peek()] < t_)
            {
                int prev = temperatureStack.Pop();
                result[prev] = i - prev;
            }
            temperatureStack.Push(i);
        }
        return result;
    }
}