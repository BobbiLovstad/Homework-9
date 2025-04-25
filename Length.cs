using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// written by Bobbi Lovstad
// 4/25/25

namespace Homework_9
{
    public class int WordLength( string s )
    {
        int length = 0;
        int i = s.Length - 1;


        while ( i > = 0 && s[i] == '')
        {
            i--;
        }


        while (i > = 0 && s[i] == '')
        {
            length++;
            i--;
        }
        return length;


    }
}
