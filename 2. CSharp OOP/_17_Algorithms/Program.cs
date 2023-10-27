using System;

namespace _17_Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //__________________________ 2 Algorithms ______________________________
            /*
                An algorithm is a set of well-defined instructions or
                a step-by-step procedure for solving a problem. Solve complex problems efficiently
             */

            //____________ Types of Algorutgns ______________
            /*
            1. Searching Algorithms
                Linear search:
                    traverse the array or list sequentially and compare each element with the target until the target is found or the end is reached.
                Binary search:
                    divide the sorted array or list into halves and repeatedly eliminate half of the remaining elements until the target is found or it's determined that the target is not in the array or list.
            
            2. Sorting Algorithms
                    Bubble sort: 
                        repeatedly swap adjacent elements if they are in the wrong order until the list is sorted.
                    Merge sort: 
                        divide the list into halves, recursively sort each half, and then merge the sorted halves.
                    Quick sort: 
                        select a pivot element, partition the list into two sub-lists (elements less than or equal to the pivot and elements greater than the pivot), and recursively sort each sub-list.

            3. Graph Algorithms
                Breadth-first search: 
                        traverse the graph level by level, starting from a given node, until a certain condition is met.
                Depth-first search: 
                        traverse the graph by exploring as far as possible along each branch before backtracking, starting from a given node.
                Dijkstra's algorithm: 
                        find the shortest path between two nodes in a weighted graph, where the weight of each edge represents the distance between the nodes.


            4. Dynamic Programming Algorithms:
                Fibonacci sequence: 
                        calculate the n-th Fibonacci number by recursively adding the previous two Fibonacci numbers (1, 1, 2, 3, 5, 8, 13, 21, ...).

                Longest common subsequence:
                        find the longest subsequence that is present in two given sequences (not necessarily contiguous).

                Knapsack problem: 
                        given a set of items, each with a weight and a value, determine the number of each item to include in a collection so that the total weight is less than or equal to a given limit and the total value is as large as possible.


            5. Recursive Algorithms:
                Factorial: 
                        calculate the factorial of a non-negative integer n by recursively multiplying it by the factorial of n-1 until n=0 (n!=123*...*n).
                Binary tree traversal: 
                        traverse a binary tree by recursively visiting the left and right subtrees of each node in a certain order (pre-order, in-order, or post-order).
                Towers of Hanoi: 
                        move a stack of disks from one pole to another, using a third pole as a temporary holding area, such that no larger disk is ever placed on top of a smaller disk.
             */





            //______________________________ 1. Searching algorithms ____________________________
            #region Search
            //____ 1. Linear search:

            //public static int LinearSearch(int[] arr, int x)
            //{
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (arr[i] == x)
            //            return i;
            //    }
            //    return -1; // Not found
            //}


            //____ 2. Binary search:
            //public static int BinarySearch(int[] arr, int x)
            //{
            //    int left = 0;
            //    int right = arr.Length - 1;
            //    while (left <= right)
            //    {
            //        int mid = (left + right) / 2;
            //        if (arr[mid] == x)
            //            return mid;
            //        else if (arr[mid] < x)
            //            left = mid + 1;
            //        else
            //            right = mid - 1;
            //    }
            //    return -1; // Not found
            //}

            #endregion


            //______________________________ 2. Sorting algorithms ____________________________
            #region Sorting 
            //_____ 1. Bubble sort _____
            //public static void BubbleSort(int[] arr)
            //{
            //    int n = arr.Length;
            //    for (int i = 0; i < n - 1; i++)
            //    {
            //        for (int j = 0; j < n - i - 1; j++)
            //        {
            //            if (arr[j] > arr[j + 1])
            //            {
            //                // Swap arr[j] and arr[j+1]
            //                int temp = arr[j];
            //                arr[j] = arr[j + 1];
            //                arr[j + 1] = temp;
            //            }
            //        }
            //    }
            //}

            //______ 2. Quick sort ________
            //public static void QuickSort(int[] arr, int left, int right)
            //{
            //    if (left < right)
            //    {
            //        int pivot = Partition(arr, left, right);
            //        QuickSort(arr, left, pivot - 1);
            //        QuickSort(arr, pivot + 1, right);
            //    }
            //}

            //private static int Partition(int[] arr, int left, int right)
            //{
            //    int pivot = arr[right];
            //    int i = left - 1;
            //    for (int j = left; j < right; j++)
            //    {
            //        if (arr[j] < pivot)
            //        {
            //            i++;
            //            // Swap arr[i] and arr[j]
            //            int temp = arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = temp;
            //        }
            //    }
            //    // Swap arr[i+1] and arr[right]
            //    int temp2 = arr[i + 1];
            //    arr[i + 1] = arr[right];
            //    arr[right] = temp2;
            //    return i + 1;
            //}
            #endregion


            //______________________________ 3. Graph algorithms: ____________________________
            #region Graph
            //_____ 1. Breadth-first search:
            //Breadth-First Search (BFS): BFS is an algorithm used to traverse and search a graph. Starting at a given node, BFS visits all of its neighboring nodes at the current level before moving on to the next level of nodes


            //public static void BFS(int[,] adjMatrix, int startVertex)
            //{
            //    int numVertices = adjMatrix.GetLength(0);
            //    bool[] visited = new bool[numVertices];
            //    Queue<int> queue = new Queue<int>();
            //    visited[startVertex] = true;
            //    queue.Enqueue(startVertex);
            //    while (queue.Count > 0)
            //    {
            //        int currentVertex = queue.Dequeue();
            //        Console.Write(currentVertex + " ");
            //        for (int i = 0; i < numVertices; i++)
            //        {
            //            if (adjMatrix[currentVertex, i] == 1 && !visited[i])
            //            {
            //                visited[i] = true;
            //                queue.Enqueue(i);
            //            }
            //        }
            //    }
            //}

            //______ 2. Dijkstra's Algorithm:  _______
            //Dijkstra's algorithm is a shortest-path algorithm used to find the shortest path between two nodes in a weighted graph. It works by assigning a tentative distance value to each node, initially infinity for all nodes except the start node (which is assigned 0), and then iteratively updating the tentative distances until the shortest path is found. Here's an

            //public static int[] Dijkstra(Graph graph, int start)
            //{
            //    int[] distances = new int[graph.Nodes.Count];
            //    bool[] visited = new bool[graph.Nodes.Count];

            //    for (int i = 0; i < distances.Length; i++)
            //        distances[i] = int.MaxValue;

            //    distances[start] = 0;

            //    for (int i = 0; i < graph.Nodes.Count - 1; i++)
            //    {
            //        int minDist = int.MaxValue;
            //        int minNode = -1;

            //        for (int j = 0; j < graph.Nodes.Count; j++)
            //        {
            //            if (!visited[j] && distances[j] < minDist)
            //            {
            //                minDist = distances[j];
            //                minNode = j;
            //            }
            //        }

            //        visited[minNode] = true;

            //        foreach (int neighbor in graph.Nodes[minNode].Neighbors)
            //        {
            //            int dist = distances[minNode] + graph.Nodes[minNode].Weights[neighbor];
            //            if (dist < distances[neighbor])
            //                distances[neighbor] = dist;
            //        }
            //    }

            //    return distances;
            //}



            #endregion


            //______________________________ 4. String Algorithms ____________________________
        }
    }
}
