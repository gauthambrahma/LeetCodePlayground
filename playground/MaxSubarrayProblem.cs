using System;

public class Solution {
    public int MaxSubArray(int[] nums) {

        //kadane's algorith
        int Current_sum = 0;
        int Max_sum = 0;
        
        foreach (int num in nums)
        {
            //is the current gretaest sum greater or the current number?
            Current_sum = Math.Max(num,num+current_sum);
            
            //is this the best cumulative sum yet?
            Max_sum = Math.Max(Current_sum,Max_sum);
        }

        return Max_sum;
    }
}