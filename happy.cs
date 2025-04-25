using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// written by Bobbi Lovstad
// 4/25/25
namespace Homework_9
{
    public bool IsHappy(int n)
    {
        HashSet<int> seen = new HashSet<int>();

        while ( n != 1 && !seen.Contains(n))
        {
            seen.Add(n);
            n = SumOfSquares(n);
        }
        return n == 1;
    }

    public int SumOfSquares (int n)
    {
        int total = 0;
        while (n>0)
        {
            int digit = n % 10;
            total += digit * digit;
            n / = 10;

        }
        return total;
        
    }
}
