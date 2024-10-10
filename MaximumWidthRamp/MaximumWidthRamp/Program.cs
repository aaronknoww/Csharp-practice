// https://leetcode.com/problems/maximum-width-ramp/solutions/265765/detailed-explaination-of-all-the-three-approaches/?envType=daily-question&envId=2024-10-10

//user its_dark
/*
Approach 1

Not exactly “find” for every index, rather consider. The problem is to find maximum of all such distances, so trick is that for many indices, we can eliminate that calculation.

For 6 0 8 2 1 5, when I know that for 0, right end of the ramp (let’s call it idx2) is 5, I needn’t calculate it for numbers occurring between 0 and 5 for the case of idx2=5, since their distance to 5 would anyways be less than the one between 0 to 5.

Classical two pointer problem. Right pointer expands the range and left pointer contracts it. The trick is that left pointer iterates over original array and right pointer iterates over an array which stores maximum no. on the right for each index.
O(n)
*/
public class Solution {
    public int MaxWidthRamp(int[] nums)
    {
        int n = nums.Length;
        int[] rMax = new int[n];
        rMax[n - 1] = nums[n - 1];
        for (int i = n - 2; i >= 0; i--) {
          rMax[i] = Math.Max(rMax[i + 1], nums[i]);
        }
        int left = 0, right = 0;
        int ans = 0;
        while (right < n) 
        {
            while (left < right && nums[left] > rMax[right]) {
                left++;
            }
            ans = Math.Max(ans, right - left);
            right++;
        }
        return ans;
        
    }
    static void Main(string[] args)
    {
       int[] nums = new int[]{1,2,5};
    
       Solution ob = new Solution();
       ob.MaxWidthRamp(nums);
      
 
    }
}