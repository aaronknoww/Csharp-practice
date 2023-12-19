using System.Reflection;

public class Solution {
    public int Rob(int[] nums)
    {
        if(nums.Length == 0)
            return 0;
        if(nums.Length == 1 )
            return nums[0];
            
        int[] dp = new int[nums.Length+1];

        dp[0] = 0;
        dp[1] = nums[0];
        dp[2] = (nums[0] > nums[1])? nums[0] : nums[1];

        for (int i = 3; i <= nums.Length; i++)
        {
            dp[i] = Math.Max(dp[i-2] + nums[i-1],dp[i-1]);
        }

        return dp[nums.Length];
    }

     static void Main(string[] args)
        {
            int[] arr = new int[] {2,7,9,3,1};
            Solution ob = new Solution();
            ob.Rob(arr);


        }
    
}