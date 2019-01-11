using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryGapFinder.Test
{
    /* 
    A binary gap within a positive integer N is any maximal sequence of consecutive zeros 
    that is surrounded by ones at both ends in the binary representation of N.

    For example, number 9 has binary representation 1001 and contains a binary gap of length 2. 
    The number 529 has binary representation 1000010001 and contains two binary gaps: 
    one of length 4 and one of length 3. 

    The number 20 has binary representation 10100 and contains one binary gap of length 1. 
    The number 15 has binary representation 1111 and has no binary gaps. 
    The number 32 has binary representation 100000 and has no binary gaps.

    Write a function:

   int solution(int N);

   that, given a positive integer N, returns the length of its longest binary gap. 
   The function should return 0 if N doesn't contain a binary gap.

   For example, given N = 1041 the function should return 5, because N has binary representation 10000010001 
   and so its longest binary gap is of length 5. 
   Given N = 32 the function should return 0, because N has binary representation '100000' and thus no binary gaps.

   Write an efficient algorithm for the following assumptions:

   N is an integer within the range [1..2,147,483,647].
    */
    public class BinaryGapFinder
    {
        public int GetMaxGap(int N)
        {
            int[] A = ConvertToBinaryArrayOfInt(N);
            
            int maxGap = 0;
            for (int i = 0; i < A.Length - 1; i++)
            {
                if (A[i] == 1)
                {
                    int gap = 0;
                    for (int j = i + 1; j < A.Length; j++)
                    {
                        if (A[j] == 0) gap++;
                        else 
                        {
                            if (gap > maxGap) maxGap = gap;
                            break;
                        }
                    }
                }
                    
            }
            return maxGap;
        }
        
        private int[] ConvertToBinaryArrayOfInt(int N)
        {
            int reqBase = 2;
            string binaryString = Convert.ToString(N, reqBase);
            List<int> list = new List<int>();
            foreach (var ch in binaryString)
            {
               list.Add(Convert.ToInt32(ch.ToString()));
            }
            return list.ToArray();
        }
    }
}
