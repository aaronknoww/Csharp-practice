
//TERMINADO Y PASO TODAS LAS PRUEBAS DE LEETCODE
public class Solution {
    public bool CanJump(int[] nums)
    {
        nums[nums.Length-1] = -1;
        for (int i = nums.Length - 2; i >= 0 ; i--)
        {
            if(i+nums[i] >= nums.Length - 1) 
                nums[i] = -1;
            else
            {
                int rep = nums[i];
                int index = i+1;
                nums[i]=-2;
                for (int r = 0; r < rep; r++)
                {
                    if(nums[index]==-1)
                    {
                        nums[i]=-1;
                        break;
                    }
                    index++;
                        
                }
            }
        }
        return (nums[0]==-1)?true:false;
        
    }
static void Main(string[] args)
{
    Solution ob = new Solution();
    int[] nums = new int[3]  {1,1,0};
    ob.CanJump(nums);
}
};

