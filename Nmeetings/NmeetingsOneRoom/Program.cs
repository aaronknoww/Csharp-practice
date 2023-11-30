//{ Driver Code Starts
//Initial Template for C#

// TERMINADO Y PASO LOS 220 CASOS DE GFG

using System;
using System.Numerics;
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
                int[] start = new int[N];
                int[] end = new int[N];
                string elements = Console.ReadLine().Trim();
                elements = elements + " " + "0";
                start = Array.ConvertAll(elements.Split(), int.Parse);
                elements = Console.ReadLine().Trim();
                elements = elements + " " + "0";
                end = Array.ConvertAll(elements.Split(), int.Parse);
                Solution obj = new Solution();
                int res = obj.maxMeetings(start, end , N);
                Console.Write(res+"\n");
          }

        }
    }
}
// } Driver Code Ends


//User function Template for C#


class Solution
    {
        private class Meeting:IComparable<Meeting>
        {
        readonly int start;
        readonly int end;

        public int Start => start;

        public int End => end;

        public Meeting(int st, int en)
        {
           this.start = st;
           this.end = en;
        }
        public static bool operator <(Meeting m1, Meeting m2)
        {
           if(m1.end <= m2.end && m1.start <= m2.start)
               return true;
           else
               return false;
        }
        public static bool operator >(Meeting m1, Meeting m2)
        {
            if(m1.end > m2.end)
                return true;
            else
                return false;
        }

        public int CompareTo(Meeting obj)
        {
            if(this.end < obj.end )
                return -1;
            else if(this.end == obj.end)
                return 0;
            else
                return 1;
            
        }
    }
        //Complete this function
        public int maxMeetings(int[] start, int[] end, int n)
        {
            List<Meeting> meetings = new List<Meeting>();
            
            for(int i=0; i<n; i++)
            {
                meetings.Add(new Meeting(start[i], end[i]));
            }
            meetings.Sort();
            Meeting last;
            int counter = 1;
            last = meetings[0];        
            for(int i=1; i<n; i++){
            if(last.End < meetings[i].Start)
            {
                counter++;
                last = meetings[i];
            }
        }
        
        return counter;
           
        }

    }
/*
1
6
1 3 0 5 8 5
2 4 6 7 9 9

1
8
75250 50074 43659 8931 11273 27545 50879 77924
112960 114515 81825 93424 54316 35533 73383 160252
*/