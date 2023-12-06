using System.Reflection.Metadata;
int[] cost = new int[10] {1,100,1,1,1,100,1,1,100,1}; // R=6;
//int[] cost = new int[3] {10,15,20};

int[] dp = new int[] {cost[0],cost[1]};
        for (int i = 2; i < cost.Length; ++i)
            dp[i%2] = cost[i] + Math.Min(dp[0],dp[1]);
//        return Math.Min(dp[0],dp[1]);
//int[] dp = new int[cost.Length+1];

// dp[0] = 0;
// dp[1] = 0;
// dp[2] = (cost[0]<cost[1]) ? cost[0] : cost[1];
// for(int i = 3; i <= cost.Length; i++ )
//     dp[i] = Math.Min(dp[i-2] + cost[i-1] + cost[i-3], dp[i-3]+cost[i-2]);

Console.WriteLine("the result is " + dp[cost.Length]);
//return dp[cost.Length];