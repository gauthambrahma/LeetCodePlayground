using System;
namespace playground
{
    public class MaxSubarrayProduct
    {
        public MaxSubarrayProduct()
        {
            //int[] input = new int[] { 2, -3, -2, -4 };
            //int[] input = new int[] { 1, -2, 3, -4 };
            int[] input = new int[] {-2};

            int output = MaxProduct(input);
            Console.WriteLine(output);
            Console.ReadLine();
        }

        public int MaxProduct(int[] nums)
        {
            int[] minimumSoFarArr = new int[nums.Length];
            int[] maximumSoFarArr = new int[nums.Length];
            int result = minimumSoFarArr[0] = maximumSoFarArr[0] = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    maximumSoFarArr[i] = Math.Max(nums[i] * maximumSoFarArr[i - 1], nums[i]);
                    minimumSoFarArr[i] = Math.Min(nums[i] * minimumSoFarArr[i - 1], nums[i]);
                }
                else
                {
                    maximumSoFarArr[i] = Math.Max(nums[i] * minimumSoFarArr[i - 1], nums[i]);
                    minimumSoFarArr[i] = Math.Min(nums[i] * maximumSoFarArr[i - 1], nums[i]);
                }
                result = Math.Max(maximumSoFarArr[i], Math.Max(minimumSoFarArr[i], result));
            }
            return result;
        }
    }
}
