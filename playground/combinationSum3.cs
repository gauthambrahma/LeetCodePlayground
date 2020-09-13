using System;
using System.Collections.Generic;
using System.Linq;

namespace playground
{
    public class combinationSum3
    {
        public combinationSum3()
        {
        }
        public IList<IList<int>> CombinationSum3(int k, int n)
        {
            IList<IList<int>> FinalResult = new List<IList<int>>();
            IList<int> result = new List<int>();
            DecomposeRecursively(FinalResult, k, n, result, 1);
            return FinalResult;
        }

        public IList<int> DecomposeRecursively(IList<IList<int>> FinalResult, int k, int sum, IList<int> selections, int pointer)
        {
            if (sum < 0)
            {
                return null;
            }

            if (sum == 0)
            {
                if (selections.Count == k)
                {
                    //deep copy- else elments removed from final list as well
                    FinalResult.Add(new List<int>(selections));
                    //selections.Clear();
                }
                return null;
            }
            if (sum > 0)
            {
                for (int i = pointer; i < 9; i++)
                {
                    selections.Add(i);
                    DecomposeRecursively(FinalResult, k, sum - i, selections, i + 1);
                    selections.RemoveAt(selections.Count - 1);
                }
            }
            return null;

        }
    }
}
