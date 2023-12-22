class Solution
{
        
public
    int maxProduct(int[] nums)
    {
        if(nums.Length == 1)
            return 0;
        if(nums.Length == 2)
            return nums[0] * nums[1];
        
        // TERMINADO PERO ESTE PROGRAMA NECESITA 2 NUMEROS PARA CONSIDERARSE MULTIPLICACION
        
        int[] dp = new int[nums.Length];
        int max = nums[0] * nums[1];
        int abs = nums[0] * nums[1];
        dp[0] = 0;
        dp[1] = nums[0] * nums[1];
            
        for(int i = 2; i<nums.Length; i++)
        {
            if(nums[i]==0)
            {
                abs = 0;
                dp[i]=0;
                if(i+2 < nums.Length)
                {
                    dp[i+1] = 0;
                    i+=1;
                }
                else if(i+1 < nums.Length)
                {
                    dp[i+1] = 0;
                }
                continue;                
            }

            abs = (abs==0)?nums[i-1]:abs;
            abs *= nums[i];
            dp[i] = Math.Max(dp[i-1]*nums[i], nums[i]*nums[i-1]);
            dp[i] = Math.Max(dp[i], abs);
            max = (max > dp[i])?max:dp[i];

        }
        return max;
            
    }
    static void Main(string[] args)
    {
       int[] nums = new int[]{0,0,1,-5,-6};
       //int[] nums = new int[]{2,3,-2,4};
       //int[] nums = new int[]{-2,0,-1};
       Solution ob = new Solution();
       ob.maxProduct(nums);
 
    }
};
/*
[2,3,-2,4]
[-2,0,-1]
*/