//{ Driver Code Starts
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
                int[] arr = new int[N];
                var stringArray = Console.ReadLine().Split(' ');
                for (int i = 0; i < N; i++)
                {
                    arr[i] = Convert.ToInt32(stringArray[i]);
                }

                Solution obj = new Solution();
                int res = obj.findSingle(N, arr);
                Console.Write(res);
                Console.Write("\n");
          }

        }
    }
}
// } Driver Code Ends


//User function Template for C#
// Funciona aplicando el EXOR debido a que cuando se le aplica esa operacion a un numero que es igual
// el resultado siempre es cero, de lo contrario va a resultar el numero que no tiene par.
// Esto solo funiciona si es un solo numero el que no tiene par.
class Solution
    {
        //Complete this function
        public int findSingle(int N, int[] arr)
        {
            int temp = 0;
            for (int i = 0; i < N; i++)
            {
                temp = temp ^ arr[i];
            }
            return temp;
        //Your code here
    }
    }

/*
1
11
1 2 3 5 3 2 1 4 5 6 6

1
5
2 1 3 2 1
*/