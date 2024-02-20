public class Solution
{
    public int UniquePaths(int m, int n)
    {
        if(m == 1 || n == 1)
            return 1;
        int[,] dp = new int[m,n];

        for(int i = 0; i< n; i++) // To set 1 in all first row.
            dp[0,i] = 1;
        
        for(int i = 0; i < m; i++) // To set 1 in all first column.
            dp[i,0] = 1;
        
        for(int r = 1; r < m; r++)
        {
            for(int c = 1; c < n; c++)
            {
                dp[r,c] = dp[r-1,c] + dp[r,c-1];
            }
        }

        return dp[m-1,n-1];

    }
    static void Main(string[] args)
    {
       int[] nums = new int[]{0,0,1,-5,-6};
       //int[] nums = new int[]{2,3,-2,4};
       //int[] nums = new int[]{-2,0,-1};
    //    Solution ob = new Solution();
    //    ob.UniquePaths(nums);
 
    }
}