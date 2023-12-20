//TERMINADO Y PASO EN LEET CODE
public class Solution {
    public int MaxSubArray(int[] nums)
    {
        int max = nums[0];
        
        for(int i = 1; i<nums.Length; i++)
        {
            nums[i] = Math.Max(nums[i-1]+nums[i], nums[i]);
            max = (nums[i]>max)?nums[i]:max;
        }
        return max;
    }
    static void Main(string [] args)
    {
        int[] nums = new int[]{-1,-2};
        Solution ob = new Solution();
        ob.MaxSubArray(nums);
    }

}