using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogRiverOne
{
    static class RiverCrossing
    {
        public static int CrossRiverMinTime(int X, int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            bool[] isStepFilled = new bool[X];
            int stepsToFill = X;
            for (int i = 0; i < A.Length; i++)
            {
                // when A[0] =3 it means at 1 second a leave falls at 3
                // that means isStepFilled should be [false,false,true, false....]
                // so isStepFilled at index (A[i] -1) is filled.
                int stepIndex = A[i] - 1;
                if (stepIndex < X && !isStepFilled[stepIndex])
                {
                    stepsToFill--;
                    isStepFilled[stepIndex] = true;
                }
                if (stepsToFill == 0) return i;
            }
            return -1;
        }
    }
}
