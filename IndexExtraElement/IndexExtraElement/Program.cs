//{ Driver Code Starts
// Initial Template for C#

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

                int[] n = new int[1];
                n = Array.ConvertAll(Console.ReadLine().Trim().Split(),int.Parse);
                int sizeOfArray = n[0];
                int[] arr = new int[sizeOfArray];
                arr = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);// input for array elements

                int[] b = new int[arr.Length - 1];

                b = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);// input for array elements
                Solution obj = new Solution();
                Console.WriteLine(obj.findExtra(arr, b, sizeOfArray));
            }

        }
    }
}
// } Driver Code Ends


//User function Template for C#

class Solution
{
    //Complete this function
    public int findExtra(int[] a, int[] b, int n)
    {
        // if(n<=100)
        // {
        //     for(int i=0; i<n-1; i++)
        //     {
        //         if(a[i]!=b[i])
        //             return i;
        //     }
        //     return n;
        // }

        for(int i=0; i<n; i++)
        {
            int ind = Array.BinarySearch(b,a[i]);
            if(Array.BinarySearch(b,a[i]) < 0)
                return i;

        }


        return 0;

        // add code here.
    }
}
/*
1
7
2 4 6 8 10 12 13
2 4 6 8 10 12
*/