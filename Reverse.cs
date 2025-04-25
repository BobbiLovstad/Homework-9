using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

// written by Bobbi Lovstad
// 4/25/25

namespace Homework_9
{
    public int ReverseString(char[] s)
    {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            char temp = s[left];
            s[left] = s[right];
            s[right] = temp;

            left++;
            right--;
        }
    }
    public static void main(string[] args)
    {
        char[] s = { };

        ReverseString(s);

        Console.WriteLine(new string(s));
}
