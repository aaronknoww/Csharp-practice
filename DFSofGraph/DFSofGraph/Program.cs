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
                adj[v].Add(u);
            }
            Solution obj = new Solution();
            var res = obj.dfsOfGraph(V, adj);
            foreach (int i in res) { Console.Write(i + " "); }
            Console.WriteLine();
        }
    }
}
}
// } Driver Code Ends


// User function Template for C#

class Solution {
    // Function to return a list containing the DFS traversal of the graph.
  public
    List<int> dfsOfGraph(int V, List<List<int>> adj)
    {
        HashSet<int> visited = new HashSet<int>();
        List<int> res = new List<int>();
        Stack<int> stk = new Stack<int>();
        bool newNode = false;

        stk.Push(0);
        visited.Add(0);
        res.Add(0);


        while(stk.Count > 0)
        {
            foreach (int node in adj[stk.Peek()] ) //To search in 1d array of adjacency nodes. 
            {
                if(!visited.Contains(node))
                {
                    res.Add(node);
                    stk.Push(node);
                    visited.Add(node);
                    newNode = true;
                    break;
                }
                
            }
            if(newNode)
            {
                newNode = false;
                continue;
            }
            stk.Pop();                    
        }

        return res;
        // Code here
    }
}
/*
1
6 5
0 4
0 5
1 2
2 5
3 4

0 4 3 5 2 1
*/