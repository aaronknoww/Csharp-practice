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
                long[] arr = new long[N];

                string elements = Console.ReadLine().Trim();
                elements = elements + " " + "0";
                arr = Array.ConvertAll(elements.Split(), long.Parse);
                Solution obj = new Solution();
                long[] res = obj.nextLargerElement(arr, N);
                for(int i = 0;i<res.Length;i++){
                    Console.Write(res[i]+" ");
                }
                Console.Write("\n");
          }

        }
    }
}
// } Driver Code Ends


//User function Template for C#


class Solution
    {
        //Complete this function
        public long[] nextLargerElement(long[] arr, int n)
        {
            Stack<long> pila = new Stack<long>();
            long[] res = new long[n];

            for(int i = n-1; i >= 0; i--)
            {
                if(pila.Count == 0)
                    res[i] = -1;
                else if(pila.Count>0 && pila.Peek()> arr[i])
                    res[i]= pila.Peek();
                else if(pila.Count>0 && pila.Peek()<= arr[i])
                {
                    while(pila.Count()>0 && pila.Peek() <= arr[i])
                      pila.Pop();
                
                    if(pila.Count() == 0) res[i] = -1;
                    else res[i] = pila.Peek();
                    
                }
                pila.Push(arr[i]);
            }

            return res;


            /*
            if(s.size() == 0) v.push_back(-1);
            else if(s.size() > 0 && s.top() > arr[i] )
                    v.push_back(s.top());
            else if(s.size()>0 && s.top() <= arr[i]){
                
                while(s.size()>0 && s.top() <= arr[i])
                      s.pop();
                
                if(s.size() == 0) v.push_back(-1);
                else v.push_back(s.top());
            }
            s.push(arr[i]);
        }
        reverse(v.begin(),v.end());
        return v;
            */

            //Your code here
        }

    }