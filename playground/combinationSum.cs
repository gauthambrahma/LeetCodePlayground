using System;
using System.Collections;
using System.Collections.Generic;

namespace playground
{
    public class combinationSum
    {
        public combinationSum()
        {

        }
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();
            List<int> subresult = new List<int>();
            constructSum(target, subresult, result, candidates[0], candidates, 0);
            return result;
        }
        public bool constructSum(int sum, IList<int> subresult, IList<IList<int>> result, int number, int[] candidates, int index)
        {
            if (sum < 0)
            {
                return false;
            }
            if (sum == 0)
            {
                result.Add(new List<int>(subresult));
            }

            if (sum > 0)
            {
                for (int i = index; i < candidates.Length; i++)
                {
                    int item = candidates[i];
                    subresult.Add(item);
                    constructSum(sum - item, subresult, result, item, candidates, i);
                    subresult.RemoveAt(subresult.Count - 1);
                }
            }
            return true;
        }
    }
}
