//output the nodes of directed graph in such a way that for any edge u->v, u appears before v in the ordering.
//there can be multiple possible ways. Output any one of them
//topo sort can be useful in builds of project where all dependencies need to be built before the dependent package

public class Graph
    {
        public int V; // No. of vertices 

        // Array of lists for Adjacency List Representation 
        public Dictionary<int, List<int>> adj;
        //public HashSet<int> visited;

        // Constructor 
       public Graph(int v)
        {
            //visited = new HashSet<int>();
            V = v;
            adj = new Dictionary<int, List<int>>();
            for (int i = 1; i <=v; ++i)
                adj.Add(i, new List<int>());
        }

        //Function to add an edge into the graph 
       public void addEdge(int v, int w)
        {
            adj[v].Add(w); // Add w to v's list. 
            //adj[w].Add(v); // this is for undirected graph
        }

        
        public Stack<int> TopologicalSort()
        {
            HashSet<int> visitedSet = new HashSet<int>();
            Stack<int> sortedNodes = new Stack<int>();

            foreach(int current in adj.Keys)
            {
                if (!visitedSet.Contains(current))
                    TSUtil(visitedSet, sortedNodes, current);
            }
            return sortedNodes;
        }

        private void TSUtil(HashSet<int> visitedSet, Stack<int> sortedNodes, int current)
        {
            //Mark current node as visited
            visitedSet.Add(current);

            //loop through all children of current
            foreach(int child in adj[current])
            {
                //recur for the child if it is not visited
                if (!visitedSet.Contains(child))
                    TSUtil(visitedSet, sortedNodes, child);
            }

            //After all the children, if any, of current node are visited, add it to topo sorted stack
            sortedNodes.Push(current);
        }      

     }

    class Program
    {

        public static void Main(string[] args)
        {

            int noOfTC = Convert.ToInt32(Console.ReadLine());

            for (int t = 0; t < noOfTC; ++t)
            {
                ////int num = Convert.ToInt32(Console.ReadLine());
                //string[] s1 = Console.ReadLine().Split(' ');
                ////int[] arr = Array.ConvertAll(s1, int.Parse);
                ////string str = Console.ReadLine();
                //int i = 0;
                Graph g = new Graph(8);

                g.addEdge(1,3);
                g.addEdge(2, 3);
                g.addEdge(2, 4);
                g.addEdge(3, 5);
                g.addEdge(4, 6);
                g.addEdge(5, 8);
                g.addEdge(5, 6);
                g.addEdge(6, 7);

                Stack<int> result=g.TopologicalSort();

                //print the result stack now
            }
            Console.ReadLine();
        }

    }
