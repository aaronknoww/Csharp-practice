using System.Collections.Immutable;
using System.Runtime.CompilerServices;

//TODO: hacer una prueba manual de cuando hay numeros repetidos y cero.

class Solution
{
    //Complete this function
    //Function to check if there is a pair with the given sum in the array.
    public int perfectSum(int[] arr, int n, int sum)
    {
        int[,] dp = new int[arr.Length+1,sum+1];
        Array.Sort(arr);
        int curSum = 0;

        for(int item = 0; item<arr.Length; item++)
        {
            // item --> row before;
            // item --> current row;
            curSum+=arr[item];
            for (int i = 1; i <=sum; i++)
            {
                if(i > curSum)
                    break;
                if(i-arr[item]>0)
                    dp[item+1,i] = dp[item,i] + dp[item,i-arr[item]]; 
                else if(i-arr[item] < 0)
                    dp[item+1,i] = dp[item,i];
                else
                    dp[item+1,i]=dp[item,i]+1;                
            }
            
        }
        return dp[arr.Length,sum];
        //Your code here
    }
    static void Main(string[] args)
    {
       //int[] nums = new int[]{9, 7, 0, 3, 9, 8, 6, 5, 7, 6};
       int[] nums = new int[]{0,2,2,5,5,3};
       int s = 15;
       //int[] nums = new int[]{2,3,-2,4};
       //int[] nums = new int[]{-2,0,-1};
       Solution ob = new Solution();
       ob.perfectSum(nums, 10,s);
    }
    

}
/*
10 31
9 7 0 3 9 8 6 5 7 6


R=40;
*/