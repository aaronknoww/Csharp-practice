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
                int N = Convert.ToInt32(Console.ReadLine());
                Solution obj = new Solution();
                List<long> res = obj.printFibb(N);
                foreach (long i in res)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
// } Driver Code Ends


//User function template for C#

// TERMINADO Y PASO EN GFG
class Solution
{
    //Complete this function
    public List<long> printFibb(int n)
    {
        if(n == 1)
            return new List<long>(){1};
        if(n == 2 )
            return new List<long>(){1,1};
        List<long> res = new List<long>();
        res.Add(1);
        res.Add(1);
        for (int i = 2; i < n; i++)
        {
            res.Add(res[i-1] + res[i-2]);
        }

        return res;
        //Your code here
    }
}