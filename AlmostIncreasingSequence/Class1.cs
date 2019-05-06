using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmostIncreasingSequence
{
    public class Class1
    {
        bool AlmostIncreasingSequencer(int[] sequence)
        {
            int removed = 0;
            int t = 0;
            for (int i = 0; i < sequence.Length - 1; i++)
            {
                if (sequence[i] >= sequence[i + 1])
                {
                    removed++;
                    t++;
                    if (t > 1)
                    {
                        removed++;
                    }
                }

                if (i + 2 < sequence.Length && sequence[i] >= sequence[i + 2])
                {
                    removed++;
                }
            }
            if (removed <= 2)
            {
                return true;
            }
            return false;
        }
    }
}
//Given a sequence of integers as an array, 
//determine whether it is possible to obtain a 
//strictly increasing sequence by removing no more than one element from the array.