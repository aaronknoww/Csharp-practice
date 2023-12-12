//{ Driver Code Starts
// Initial Template for C#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverCode {

class GFG {
    static void Main(string[] args) {
        int testcases; // Taking testcase as input
        testcases = Convert.ToInt32(Console.ReadLine());
        while (testcases-- > 0) // Looping through all testcases
        {
            var ip = Console.ReadLine().Trim().Split(' ');
            int V = int.Parse(ip[0]);
            int E = int.Parse(ip[1]);
            List<List<int>> adj = new List<List<int>>();
            for (int i = 0; i < V; i++) {
                adj.Add(new List<int>());
            }
            for (int i = 0; i < E; i++) {
                ip = Console.ReadLine().Trim().Split(' ');
                int u = int.Parse(ip[0]);
                int v = int.Parse(ip[1]);
                adj[u].Add(v);
            }
            Solution obj = new Solution();
            var res = obj.bfsOfGraph(V, adj);
            foreach (int i in res) { Console.Write(i + " "); }
            Console.WriteLine();
        }
    }
}
}
// } Driver Code Ends


// User function Template for C#

// TERMINADO Y PASO LOS 1125 DE GFG

class Solution {

    // Function to return Breadth First Traversal of given graph.
  public
    List<int> bfsOfGraph(int V, List<List<int>> adj)
    {
        List<int> res = new List<int>(); 
        HashSet<int> visited = new HashSet<int>();
        Queue<int> que = new Queue<int>();

        visited.Add(0);
        res.Add(0);
       
        foreach (int n in adj[0])
        {
            if(visited.Add(n))
            {
                res.Add(n);
                que.Enqueue(n);
            }
        }

        while (que.Count > 0)
        {
            foreach (int n in adj[que.Peek()])
            {
                if(visited.Add(n))
                {
                    res.Add(n);
                    que.Enqueue(n);
                }
            }
            que.Dequeue();                
                        
        }
        return res;
    }
}
/*
1
6 5
0 4
0 5
1 2
2 0
3 4
*/