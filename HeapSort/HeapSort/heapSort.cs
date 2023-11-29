//{ Driver Code Starts
//Initial Template for C#


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
                int[] arr = new int[N];

                string elements = Console.ReadLine().Trim();
                elements = elements + " " + "0";
                arr = Array.ConvertAll(elements.Split(), int.Parse);

                Solution obj = new Solution();
                obj.heapSort(arr, N);
                for(int i = 0;i<N;i++){
                    Console.Write(arr[i]+" ");
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
        
        //Heapify function to maintain heap property.
        
        // This function is in charge to swap nodes between father and sons, in order to maintain heap properties.
        public void heapify(int[] arr, int n, int i)  
        {
             int largest = i;
             int left = 2*i + 1;
             int right = 2*i + 2;
             if(left<n&&arr[left]>arr[largest])
             {
                 largest = left;
             }
             if(right<n&&arr[right]>arr[largest])
             {
                 largest = right;
             }
             if(i!=largest)
             {
                int aux = 0;
                //swap(arr[i],arr[largest]);
                aux = arr[i];
                arr[i] = arr[largest];
                arr[largest] = aux;
                 heapify(arr,n,largest);
             }
             return; 
          // Your Code Here
        }
        //Function to build a Heap from array.
        //This function builds a heap from scratch, for which it uses the hipify function. This only runs once
        public void buildHeap(int[] arr, int n)  
        {
             for(int i = n/2-1;i>=0;i--)
             {
                heapify(arr,n,i);
             }
        // Your Code Here
        }
        //Function to sort an array using Heap Sort.
        public void heapSort(int[] arr, int n)
        {
             int aux = 0;
             buildHeap(arr,n);
             for(int i = n-1;i>0;i--)
             {
                
                aux = arr[0];
                arr[0] = arr[i];
                arr[i] = aux;
                heapify(arr,i,0);
             }
            //code here
        }       

    }
/*
1
5
4 1 3 9 7

1
10
1 2 3 4 5 6 7 8 9 10
*/