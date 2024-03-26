using System.Runtime.CompilerServices;

// TERMINADO Y PASO EN LEET CODE
public class Solution {
    public IList<int> FindDuplicates(int[] nums)
    {
        int[] l = new int[nums.Length];
        List<int> res = new List<int>();
        foreach (int item in nums)
        {
            l[item-1]++;
            if(l[item-1]==2)
                res.Add(item);
        }
        return res;
        
    }
    static void Main(string[] args)
    {
       int[] nums = new int[]{4,3,2,7,8,2,3,1};
       int amount = 11;
    
       Solution ob = new Solution();
       ob.FindDuplicates(nums);
      
 
    }
}