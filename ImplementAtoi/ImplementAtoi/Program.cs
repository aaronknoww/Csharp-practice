//{ Driver Code Starts
//Initial Template for C#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
                string name = Console.ReadLine().Trim();
                Solution obj = new Solution();
                int res = obj.atoi(name);
                Console.Write(res+"\n");
          }

        }
    }
}

// } Driver Code Ends


//User function template for C#

class Solution{
  //Complete this function
  public int atoi(String str)
  {
      bool minus = false;
    int res = 0;
    int mul = 1;
    Dictionary<char,int> dict = new Dictionary<char, int>
    {
        {'0',0},
        {'1',1},
        {'2',2},
        {'3',3},
        {'4',4},
        {'5',5},
        {'6',6},
        {'7',7},
        {'8',8},
        {'9',9}
    };
    if(str[0]=='-')
    {
        minus = true;
        str = str.Remove(0,1);
    }

    foreach(char c in str.Reverse())
    {
        if(c < '0' || c > '9')
            return -1;
        res+= dict[c] * mul;
        mul*=10;       

    }
    
    return (minus)?res = res*-1:res;
    //Your code here
  }
}