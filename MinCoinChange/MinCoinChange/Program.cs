public class Solution
{
    public int CoinChange(int[] coins, int amount)
    {
        if(amount == 0)
            return 0;
        
        Array.Sort(coins);
        
        if(amount == 1)
            return (coins[0] == 1)? 1 : -1;
        if(coins[0]>amount)
            return -1;
        if( Array.BinarySearch(coins,amount)>0)
            return 1;    

        int[] dp = new int[amount+1];
        const int INF = int.MaxValue-10;
        int min = int.MaxValue;
        
        for (int i = 0; i < coins[0]; i++)
            dp[i] = INF;
           
        
        dp[0] = 0;
        dp[1] = (coins[0] == 1)? 1 : INF;
        for(int i = coins[0]; i<=amount; i++)
        {
            foreach(int c in coins)
            {
                if(c>i)
                    break;
                if(c == i)
                {
                    min = 1;
                    break;
                }           
                min =(1+dp[i-c] < min)?1+dp[i-c]:min;                
            }
            dp[i]= min;
            min = INF;
        }

        return (dp[amount] < INF)?dp[amount]:-1;
    }
    static void Main(string[] args)
    {
       int[] nums = new int[]{1,2,5};
       int amount = 11;
    
       Solution ob = new Solution();
       ob.CoinChange(nums,amount);
      
 
    }
}
