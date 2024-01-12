public class Solution {
    public int IntegerReplacement(int n)
    {
        int c = 0;
        while (n != 1)
        {
            if ((n & 1) == 0)
            {
                n >>>= 1;
            } else if (n == 3 || ((n >>> 1) & 1) == 0)// lo importante es lo que hace con el corrimento de bits y el and 
            {
                --n;
            } else
            {
                ++n;
            }
            ++c;
    }
    return c;
        
    }
    static void Main(string[] args)
        {
            Solution ob = new Solution();
            int n = 7;
            ob.IntegerReplacement(n);

            int testcases;// Taking testcase as input
            testcases = Convert.ToInt32(Console.ReadLine());
            

        }
}