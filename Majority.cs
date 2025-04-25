using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// written by Bobbi Lovstad
// 4/25/25

namespace Homework_9
{
    public int MajorityElement ( int[] nums)
    {
        int count = 0;
        int candidate = 0;

        foreach( int num in nums)
        {
            if (count == 0)
            {
                candidate = num;
            }

            count += (num == candidate) ? 1 : -1;
        }
        return candidate;
    }
}
