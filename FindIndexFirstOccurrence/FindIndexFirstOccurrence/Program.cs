public class Solution
{
    private int[]? kmp;
    private void checkPattern(string patt)
    {
        if(patt.Length < 2)
            return;
            
        int first = 0;
        int last = 1;

        while (last < patt.Length)
        {
            if(patt[first] == patt[last])
            {
                kmp[last] = ++first;
                last++;
            }
            else
            {
                if(first>0)
                {
                    first = kmp[first-1];
                }
                else
                {
                    kmp[last] = 0;
                    last++;
                }
            }            
        }
    }
    public int StrStr(string haystack, string needle)
    {
        
        if(haystack.Length < needle.Length)
            return -1;

        kmp = new int[needle.Length];
        checkPattern(needle);

        int next = 0;
        int k = 0;

        while (next < haystack.Length)
        {
            if (haystack[next] == needle[k])
            {
                next++;
                k++;
                if( k >= kmp.Length)
                    return next - kmp.Length;                                
            }
            else
            {
                while(k > 0)
                {
                    k = kmp[k-1];
                    if(needle[k] == haystack[next])
                    {
                        k++;
                        break;
                    }
                }
                next++;
            }                       

        }
        return -1;        
    }

static void Main(string[] args)
    {
       int[] nums = new int[]{0,0,1,-5,-6};
       Solution ob = new Solution();
       //ob.StrStr("sadbutsad","sad");
       //ob.StrStr("aaaabaaabcacaaa","aaabaaabc");
       ob.StrStr("abc","c");
 
    }
}