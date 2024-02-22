public class Solution {
    public int RangeBitwiseAnd(int left, int right) {
        int cnt = 0;
        while (left != right) {
            left >>= 1;
            right >>= 1;
            cnt++;
        }
        return (left << cnt);
        
    }

    static void Main(string[] args)
    {
       int[] nums = new int[]{0,0,1,-5,-6};
       Solution ob = new Solution();
       ob.RangeBitwiseAnd(1,2147483647);

    
    }
}