using System;

public class Solution {
    public string ReversePrefix(string word, char ch)
    {
        //List<char> w = new List<char>();
        //w = word.ToList();
        string w = new string(word);
        string inv = "";
        int i = 0;
        foreach (char c in w)
        {
            if(c == ch)
            {
                inv = c + inv;
                i++;
                w = w.Remove(0, i);
                return inv + w.ToString();
            } 
            inv = c + inv;
            i++;
            
        }
        return word;
    }

    static void Main(string[] args)
    {   

        string w = "abcdefd";
        char c = 'd';
       int[] nums = new int[]{-4,-1,0,3,10};
       
       //return res;


      Solution ob = new Solution();
       ob.ReversePrefix(w,c);

    
    }
}