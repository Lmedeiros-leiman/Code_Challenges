using System;
using System.Collections.Generic;

public class PrimeDecomp
{
    public static String factors(int lst)
    {
        var primes = new List<string>();
        for (var number = 2; number <= lst; number++)
        {
            var count = 0;
            while (lst % number == 0) { count++; lst /= number; }
            if (count == 0) continue;
            primes.Add(String.Format(count > 1 ? "({0}**{1})" : "({0})", number, count));
        }
        return String.Join("", primes);
    }
}