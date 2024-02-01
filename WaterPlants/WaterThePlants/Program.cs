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
                int N = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[N];

                string elements = Console.ReadLine().Trim();
                elements = elements + " " + "0";
                arr = Array.ConvertAll(elements.Split(), int.Parse);

                Solution obj = new Solution();
                int res = obj.min_sprinklers(arr, N);
                Console.Write(res+"\n");
          }

        }
    }
}
// } Driver Code Ends


//User function Template for C#

class Solution
{
    private class Sprinkler :  IComparable<Sprinkler>, IComparer<Sprinkler>
    {
        private readonly int begin;
        private readonly int end;

        public Sprinkler(int b, int e)
        {
            this.begin = b;
            this.end = e;
        }

        public int End { get => end; }
        public int Begin { get => begin;}

        public int Compare(Sprinkler? x, Sprinkler? y)
        {
            if(x.End > y.End)
                return 1;
            else if(x.End == y.End)
                return 0;
            else
                return -1;
        }

        public int CompareTo(Sprinkler? other)
        {
            if(this.End > other.End)
                return 1;
            else if(this.End == other.End)
                if(this.Begin<other.Begin)
                    return 1;
                else if(this.Begin>other.Begin)
                    return -1;
                else
                    return 0;
            else
                return -1;
        }   

  
    }
    //Complete this function
    public int min_sprinklers(int[] gallery, int n)
    {
        SortedDictionary<int, int> sd = new SortedDictionary<int, int>(); 
        //SortedSet<Sprinkler> ss = new SortedSet<Sprinkler>();
        //List<Sprinkler> tbl = new List<Sprinkler>();
        int b = 0;
        int e = 0;

        for (int i = 0; i < n; i++)
        {
            if(gallery[i]==-1 && !sd.ContainsKey(-1))
            {
                sd.Add(-1,-1);
                continue;
            }
            b = (i-gallery[i] < 0)?0:i-gallery[i];
            e = (i+gallery[i] > n-1)?n-1:i+gallery[i];
            
            if(sd.ContainsKey(e))
            {
                sd[e] = (b>sd[e])?sd[e]:b;
            }
            else
                sd.Add(e,b);           
            
        }

        List<KeyValuePair<int,int>> ls = sd.Reverse().ToList();
        
        if(ls[0].Key < n-1)
            return -1;
        if(ls[0].Value == 0)
            return 1;
        
        int minIndx = ls[0].Value; // to store and know until what index is cover.
        int newMin = int.MaxValue;
        int range = ls[0].Key - ls[0].Value; // To know if the range is zero.
        int cont = 1;
        int idx = 0;   
    
        while(idx < ls.Count)
        {
            if(minIndx <= 0)
                return cont+1;
            if( minIndx > ls[idx].Key)
                 return -1;
            
            if(range == 0)
            {
                if(idx+1 < ls.Count && ls[idx].Key - ls[idx+1].Key > 1)
                    return -1; // There is a spot without cover of water.
                cont++;
                idx++;
                range = ls[idx].Key - ls[idx].Value;
                minIndx = ls[idx].Value;
                if(minIndx <= 0)
                    return cont;
                continue; 
            }

            while(minIndx < ls[idx].Key)
            {
                if(ls[idx].Value < minIndx )
                {
                    if(ls[idx].Value == 0)
                        return ++cont;
                    newMin = ls[idx].Value;
                    range = ls[idx].Key - ls[idx].Value;
                }
                idx++;
            }
            if(newMin == int.MaxValue && ls[idx-1].Key - ls[idx].Key > 1)
            {
                return -1; // Because exist a spot or plant without cover.
            }                        
            if(ls[idx].Value < minIndx)
            {
                newMin =  ls[idx].Value;
                range = ls[idx].Key - ls[idx].Value;
            }
            minIndx = newMin;
            cont++;
            newMin = int.MaxValue;
        }

        return ( minIndx  <= 0 ) ? cont + 1 : -1;
        // code here
    }
}
/*
1
8
1 0 4 2 0 6 2 4

1
6
1 2 2 -1 0 0

1
9
2 3 4 -1 2 0 0 -1 0
r -1

1
4
0 0 0 0

1
841
6 4 3 16 15 19 10 7 5 18 15 12 1 7 1 7 14 13 13 19 2 16 16 8 0 -1 8 1 9 0 8 14 15 15 0 4 0 10 2 18 14 11 19 1 5 14 20 2 15 12 13 5 16 12 12 15 6 9 9 16 13 11 17 5 18 0 11 9 1 9 11 2 5 20 6 15 20 1 17 16 4 11 -1 7 19 17 7 11 2 5 17 1 16 15 16 14 6 3 16 5 8 5 8 4 7 10 11 3 -1 5 13 8 4 17 4 3 14 17 12 19 0 4 15 4 9 0 15 20 2 6 10 20 7 17 9 19 17 -1 4 2 1 16 20 11 7 8 20 2 14 4 14 5 9 17 0 4 9 -1 19 19 3 0 1 4 5 4 4 4 19 17 13 11 6 10 13 18 5 12 5 16 10 9 20 8 0 0 6 7 7 13 0 1 19 10 10 1 16 1 9 6 16 4 11 9 6 7 8 17 8 7 -1 13 18 13 19 11 19 6 15 7 10 0 14 18 19 7 12 10 7 1 18 16 15 1 4 14 0 5 4 17 18 9 11 18 9 11 20 18 5 15 1 1 17 3 7 5 2 15 -1 0 1 2 13 15 0 2 8 19 8 0 11 8 -1 7 8 18 5 3 -1 20 15 10 18 13 9 5 20 2 11 19 4 4 13 16 1 14 15 5 6 5 16 14 8 12 13 16 3 3 10 13 5 -1 14 20 1 19 14 11 15 15 18 13 17 16 18 5 20 6 14 2 17 10 4 13 4 3 -1 20 16 7 -1 20 18 15 8 1 5 2 0 9 7 16 4 9 3 5 3 4 14 3 12 13 7 18 10 4 5 20 7 8 2 7 12 8 18 15 20 3 5 20 18 4 10 2 0 1 5 7 3 2 1 13 14 3 -1 5 -1 14 4 18 14 20 19 19 17 10 14 13 18 3 1 -1 3 9 7 17 14 9 18 1 12 17 14 8 3 9 16 16 17 13 13 0 6 4 17 9 3 14 12 0 16 2 18 18 16 16 5 20 4 14 10 6 17 7 19 7 5 2 -1 12 15 3 19 19 3 3 3 18 7 18 18 8 5 3 4 10 8 6 5 9 11 4 0 18 16 14 11 14 14 6 16 18 6 17 16 20 -1 -1 17 17 10 3 7 2 2 13 6 13 12 10 9 10 9 8 1 14 14 2 4 19 3 13 3 9 0 6 0 4 14 -1 12 10 11 16 15 12 16 18 14 -1 0 3 15 5 18 8 5 17 0 9 16 20 5 15 19 9 17 15 16 15 14 13 3 6 5 20 9 16 5 2 8 11 7 12 3 2 -1 19 17 19 15 2 2 5 10 0 20 -1 20 3 8 10 15 15 10 8 2 19 3 9 16 9 20 17 18 17 0 11 14 15 16 15 6 2 4 12 1 3 11 20 18 14 -1 11 -1 5 19 19 7 4 11 16 -1 12 11 1 14 1 18 10 2 17 0 2 9 -1 2 3 3 2 11 3 16 6 10 16 10 6 12 18 12 6 7 10 4 14 7 15 20 13 0 18 9 11 11 17 20 12 19 12 18 0 16 19 -1 5 14 18 0 15 14 7 6 7 7 9 10 17 17 3 10 20 4 7 5 5 13 14 5 4 12 17 9 14 -1 14 11 7 19 3 13 8 16 2 8 14 2 -1 6 9 12 8 19 20 10 19 11 5 7 10 16 2 15 1 -1 15 8 -1 5 1 17 16 16 10 8 17 18 13 11 12 1 3 5 19 1 1 16 2 2 10 13 5 16 14 3 17 1 7 2 6 14 9 8 8 0 10 0 11 7 13 10 1 0 -1 8 7 2 17 6 16 19 15 17 7 2 9 0 3 13 11 7 3 5 7 9 6 7 4 6 2 13 9 -1 4 18 4 17 5 4 5 16 19 12 17 2 9 16 8 2 20 4

r=25

*/
