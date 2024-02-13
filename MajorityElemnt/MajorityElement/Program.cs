using System.Collections.Immutable;

public class Solution
{
    public int MajorityElement(int[] nums)
    {
        Array.Sort(nums);
        return nums[nums.Length/2];
        // var g = nums.GroupBy( i => i ).OrderByDescending(group => group.Count());
        // var l = g.ToList();
        // l[0].Key;
    
        // int deb = 0;
       // return 0;
 
    }
    static void Main(string[] args)
    {
        Solution ob = new Solution();
        ob.MajorityElement(new int[] {1,1,3,3, 1,1});

    }
}