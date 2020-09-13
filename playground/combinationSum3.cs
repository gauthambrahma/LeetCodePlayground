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
        private IList<IList<int>> FinalResult = new List<IList<int>>();
        public IList<IList<int>> CombinationSum3(int k, int n)
        {
            IList<int> selection = new List<int>();
            for (int i = 1; i < n / 2; i++)
            {
                selection = DecomposeRecursively(n, n, k, selection, i);
                if (selection == null)
                {
                    continue;
                }
                //result.Add(selection.OrderBy(x => x).ToList());
                //foreach (var num in selection)
                //{
                //    Console.WriteLine(num);
                //}
                selection.Clear();
                //Console.WriteLine("-----");
            }
            return FinalResult;
        }

        public IList<int> DecomposeRecursively(int originalNum, int number, int length, IList<int> results, int pointer)
        {

            number = number - pointer;
            //guard clause - no duplicates
            if (results.Contains(number) || results.Contains(pointer))
            {
                return null;
            }
            results.Add(pointer);
            if (results.Count == length - 1)
            {
                int sumOfElements = results.Sum(x => x);
                if (sumOfElements + number == originalNum)
                {
                    results.Add(number);

                    return results.OrderBy(x => x).ToList();
                }
                else
                {
                    return null;
                }
            }
            else
            {
                pointer++;
                IList<int> res = DecomposeRecursively(originalNum, number, length, results, pointer);
                if (res != null)
                {
                    FinalResult.Add(res);
                    return DecomposeRecursively(originalNum, number, length, results, ++pointer);
                }

                else
                {
                    return null;
                }
                //return null;
            }
        }
    }
}
