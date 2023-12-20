// TERMINADO Y PASO LOS 19 CASOS DE LEET CODE
public class Solution {
    public bool IsSubsequence(string s, string t)
    {
        if(s == t)
            return true;
        if(s.Length == 0 || t.Length == 0)
            return false;

        if(s.Length <= t.Length)
            return isSub(s, t);
        else
            return isSub(t, s);
    }
    private bool isSub(string smaller, string bigger)
    {
        int iter = 0;
        int counter = 0;
        foreach (char ch in smaller)
        {
            iter = bigger.IndexOf(ch, iter);
            if(iter==-1)
                return false;
            counter++;
            iter++;
            if(iter>= bigger.Length)
                break;
                     
        }

        return (counter == smaller.Length)?true: false;        

    }
    static void Main(string[] args)
    {
        string s1 = "abc";
        string s2 = "ahbgdc";
        Solution ob = new Solution();
        ob.IsSubsequence(s1, s2);

    }
}

/*
s =
"aaaaaa"
t =
"bbaaaa"
*/