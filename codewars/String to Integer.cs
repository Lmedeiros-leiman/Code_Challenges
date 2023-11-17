public class Solution
{
    public int MyAtoi(string s)
    {
        int index = 0;
        int sign = 1;
        int result = 0;

        // Step 1: Read and ignore leading whitespace
        while (index < s.Length && Char.IsWhiteSpace(s[index]))
        {
            index++;
        }

        // Step 2: Check for a sign character
        if (index < s.Length && (s[index] == '-' || s[index] == '+'))
        {
            sign = (s[index] == '-') ? -1 : 1;
            index++;
        }

        // Step 3: Read digits and convert to an integer
        while (index < s.Length && Char.IsDigit(s[index]))
        {
            int digit = s[index] - '0';

            // Check for integer overflow
            if (result > (int.MaxValue - digit) / 10)
            {
                return (sign == 1) ? int.MaxValue : int.MinValue;
            }

            result = result * 10 + digit;
            index++;
        }

        // Apply the sign
        result *= sign;

        return result;
    }
}