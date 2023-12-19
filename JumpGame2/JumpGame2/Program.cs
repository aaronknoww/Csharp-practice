public class Solution {
    public int Jump(int[] nums)
    {
       const int M = 2147483645;
       int min = M;
       bool test = false;

        nums[nums.Length-1] = 0;
        for (int i = nums.Length - 2; i >= 0 ; i--)
        {
            if(i+nums[i] >= nums.Length - 1) 
                nums[i] = 1;
            else if(nums[i] == 0)
                nums[i] = M;
            else
            {
                int rep = nums[i];
                int index = i+1;
                
                for (int r = 0; r < rep; r++)
                {
                                     
                    if(nums[index] == 1)
                    {
                        nums[i] = 2;//becaus alway have to jump at least 1.
                        test = true;
                        break;
                    }
                    if(nums[index] < min)
                    {
                        min = nums[index];
                    }
                    index++;
                        
                }
                
                nums[i] = (test)?nums[i] : min + 1;
                test = false;
                min = M;
            }
        }
        return nums[0];
    }
    
static void Main(string[] args)
{
    Solution ob = new Solution();
    int[] nums = new int[3]  {1,1,0};
    ob.Jump(nums);
}
};
