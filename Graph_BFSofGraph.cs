// This class represents a directed graph using adjacency list 
// representation 
public class Graph
    {
        private int V; // No. of vertices 

        // Array of lists for Adjacency List Representation 
        private Dictionary<int,List<int>> adj;
            Dictionary<int, bool> visited;

            // Constructor 
            Graph(int v)
        {
                visited = new Dictionary<int, bool>();
                V = v;
            adj = new Dictionary<int, List<int>>();
            for (int i = 0; i < v; ++i)
                adj.Add(i,new List<int>());
        }

        //Function to add an edge into the graph 
        void addEdge(int v, int w)
        {
            adj[v].Add(w); // Add w to v's list. 
        }

        void BFS(int start)
            {
                

                Queue<int> queue = new Queue<int>();
                visited.Add(start, true); 

                while(queue.Count!=0)
                {
                    int temp = queue.Dequeue();
                    Console.WriteLine(temp);

                    foreach(int x in adj[temp])
                    {
                        if (!visited.ContainsKey(x))
                        {
                            queue.Enqueue(x);
                            visited.Add(x, true);
                        }
                           
                    }
                }
            }

       

        // Driver code
        public static void Main(String[] args)
        {
            Graph g = new Graph(4);

            g.addEdge(0, 1);
            g.addEdge(0, 2);
            g.addEdge(1, 2);
            g.addEdge(2, 0);
            g.addEdge(2, 3);
            g.addEdge(3, 3);

            Console.WriteLine("Following is Depth First Traversal");

            foreach(KeyValuePair<int,List<int>> kvp in g.adj)
                {
                    if(!g.visited.ContainsKey(kvp.Key))
                    {
                        g.BFS(kvp.Key);
                    }
                }
        }
    }
