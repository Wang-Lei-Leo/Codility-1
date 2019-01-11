using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclicRotation.Test
{
    public static class Rotate
    {
        public static int[] RotateRight(int[] A, int times)
        {
            if (A.Length < 2) return A;
            for (int i = 0; i < times; i++)
            {
                RightRotateByOne(A);
            }
            return A;
        }
        // 100% score at following url
        //https://app.codility.com/demo/results/training9H2EY8-U2H/

        public static int[] RotateLeft(int[] A, int times)
        {
            if (A.Length < 2) return A;
            for (int i = 0; i < times; i++)
            {
                LeftRotateByOne(A);
            }
            return A;
        }
        static void RightRotateByOne(int[] A)
        {
            int n = A.Length - 1;
            int i, temp = A[n];
            for (i = n; i > 0; i--)
            {
                A[i] = A[i - 1];
            }
            A[0] = temp;
        }
        static void LeftRotateByOne(int[] A)
        {
            int n = A.Length - 1;
            int i, temp = A[0];
            for (i = 0; i < n; i++)
            {
                A[i] = A[i + 1];
            }
            A[i] = temp;
        }
    }
}
