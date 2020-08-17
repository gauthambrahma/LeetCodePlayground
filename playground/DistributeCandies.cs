//Leetcode problem --> https://leetcode.com/explore/challenge/card/august-leetcoding-challenge/551/week-3-august-15th-august-21st/3427/

using System;
using System.Linq;

namespace playground
{
    public class DistributeCandies
    {
        public static void Main()
        {
            //int[] result = _DistributeCandies(7, 4);
            int[] result = _DistributeCandies(10, 3);
            result.ToList().ForEach(x => Console.WriteLine(x));
        }

        public static int[] _DistributeCandies(int candies, int num_people)
        {
            int[] result = new int[num_people];
            int allocation = 0, index = 0;
            while (candies > 0) {
                //start from beginning 
                if (index >= num_people) {
                    index = 0;
                }

                allocation++;
                
                if (candies > allocation)
                {
                    result[index] += allocation;
                    candies = candies - allocation;
                }
                else
                {
                    result[index] += candies;
                    candies = 0;
                }
                index++;
            }
            return result;
        }
    }
}
