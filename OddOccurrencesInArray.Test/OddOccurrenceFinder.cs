using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurrencesInArray.Test
{
    static class OddOccurrenceFinder
    {
        public static int Find(int[] A)
        {
            if (A.Length == 0) return 0;
            int unMatchNumber = A[0];
            // ^ is XOR operator
            for (int i = 1; i < A.Length; i++)
            {
                unMatchNumber = unMatchNumber ^ A[i];
            }
            return unMatchNumber;
        }
        // 100% score at following url
        //https://app.codility.com/demo/results/trainingNAMCHP-EYT/
    }
}
