//{ Driver Code Starts
//Initial Template for C#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DriverCode
{

    class GFG
    {
        static void Main(string[] args)
        {
            int testcases;// Taking testcase as input
            testcases = Convert.ToInt32(Console.ReadLine());
            while (testcases-- > 0)// Looping through all testcases
            {
                

                string a = Console.ReadLine().Trim();
                Solution obj = new Solution();
                bool res = obj.checkPangram(a);
                if(res){
                    Console.Write(1);
                }
                else{
                    Console.Write(0);
                }
                Console.Write("\n");
          }

        }
    }
}

// } Driver Code Ends


//User function template for C#

class Solution
{
    //Function to check if a string is Pangram or not.
    public bool checkPangram(string s)
    {
        //using regex
        // string pattern = @"[^a-z]";
        // string substitution = @"";
        // HashSet<char> alphabet = new HashSet<char>();    
        // RegexOptions options = RegexOptions.Multiline;
        // s = s.ToLower();
        // Regex myReg = new Regex(pattern, options);
        // s = myReg.Replace(s, substitution);
        // if(s.Length < 26)
        //      return false;

        HashSet<char> alphabet = new HashSet<char>();
        s=s.ToLower();
        foreach (char l in s)        
            if(l>='a'&& l<='z')
                alphabet.Add(l);

        return (alphabet.Count == 26 )?true:false;
        // your code here
    }
}

/*
1
Bawds jog, flick quartz, vex nymph
*/