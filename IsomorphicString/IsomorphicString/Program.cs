
// TERMINADO Y PASO EN LEET CODE
public class Solution {
    public bool IsIsomorphic(string s, string t)
    {
        if(s.Length != t.Length)
            return false;
        HashSet<char> finded = new HashSet<char>();
        Dictionary<char,char> d = new Dictionary<char, char>();

        d.Add(s[0],t[0]);
        finded.Add(t[0]);

        for(int i = 1; i < s.Length; i++)
        {
            if(d.ContainsKey(s[i]))
            {
                if(d[s[i]]!=t[i])
                    return false;

            }
            else
            {
                if(finded.Contains(t[i]))
                    return false;
                d.Add(s[i],t[i]);
                finded.Add(t[i]);
            }

        }
        return true;
    }
     static void Main(string[] args)
    {
       //int[] nums = new int[]{4,3,2,7,8,2,3,1};
       //int amount = 11;
       string s = "paper";
       string t = "title";

    
       Solution ob = new Solution();
       ob.IsIsomorphic(s,t);
      
 
    }
}