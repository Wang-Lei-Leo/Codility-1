using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermMissingElem.Test
{
    static class MissingElementFinder
    {
        // Check 100 % score at https://app.codility.com/demo/results/trainingRYAXWT-ACC/
        public static int Find(int[] A)
        {
            // The array has N elements and 1 element is missing.
            // So if array has 4 elements that means it should have 5 elements because one element is missing
            // Sum of 1, 2, ....,N = N(N+1)/2
            // in case of large values of integers, the sum would overflow therefore we will store the sum in a double variable
            
            // n is the the length of an array if there was no missing number
            double n = A.Length + 1;
            // the sum of all numbers if there was no missing number
            double totalSum = (double)((n * (n + 1)) / 2);

            // Now take the sum of numbers of array where there is a missing number
            double actualSum = 0D;
            for (int i = 0; i < A.Length; i++)
            {
                actualSum += A[i];
            }
            int diff = (int)(totalSum - actualSum);            

            return diff == 0 ? A.Length + 1 : diff;
           
        }
    }
}
