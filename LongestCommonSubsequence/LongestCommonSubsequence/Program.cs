//{ Driver Code Starts
//Initial Template for C#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverCode
{

    class GFG
    {
        static void Main(string[] args)
        {
            int testcases;// Taking testcase as input
            testcases = Convert.ToInt32(Console.ReadLine());
            while (testcases-- > 0)// Looping through all testcases
            {
                var ip = Console.ReadLine().Trim().Split(' ');
                int n = int.Parse(ip[0]);
                int m = int.Parse(ip[1]);
                string s = Console.ReadLine().Trim();
                string s1 = Console.ReadLine().Trim();
                Solution obj = new Solution();
                Console.WriteLine(obj.lcs(n, m, s, s1));
            }

        }
    }
}

// } Driver Code Ends


class Solution
{
    public int lcs(int n, int m, string s1, string s2)
    {
        int[,] dp = new int[n+1,m+1];

        for(int r = n-1; r >= 0;r--)
        {
            for(int c = m-1; c >=0; c--)
            {
                if(s1[r]==s2[c])
                    dp[r,c] = dp[r+1,c+1] + 1;
                else
                    dp[r,c] = Math.Max(dp[r,c+1], dp[r+1,c]);
            }
        }
        
        return dp[0,0];
        //Your code here
    }
}
/*
1
6 6
ABCDGH
AEDFHR
*/