using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogJump.Test
{
    /*
    A small frog wants to get to the other side of the road. 
    The frog is currently located at position X and wants to get to a position greater than or equal to Y. 
    The small frog always jumps a fixed distance, D.

    Count the minimal number of jumps that the small frog must perform to reach its target.

    Write a function:

    class Solution { public int solution(int X, int Y, int D); }

    that, given three integers X, Y and D, 
    returns the minimal number of jumps from position X to a position equal to or greater than Y.

    For example, given:

      X = 10
      Y = 85
      D = 30
    the function should return 3, because the frog will be positioned as follows:

    after the first jump, at position 10 + 30 = 40
    after the second jump, at position 10 + 30 + 30 = 70
    after the third jump, at position 10 + 30 + 30 + 30 = 100
    Write an efficient algorithm for the following assumptions:

    X, Y and D are integers within the range [1..1,000,000,000];
    X ≤ Y.
     */
    static class Jumper
    {
        // 100% score at following url
        //https://app.codility.com/demo/results/trainingQNHS2S-VR8/
        public static int Jump(int startPos, int endPos, int jumpDistance)
        {
            int distance = endPos - startPos;
            if (distance <= 0) return 0;
            int noOfFullJumps = distance / jumpDistance;
            int remainingDistance = distance % jumpDistance;
            if (remainingDistance > 0) noOfFullJumps++;
            return noOfFullJumps;
        }
    }
}
