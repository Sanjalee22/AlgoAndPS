   public class Graph
    {
        public int V; // No. of vertices 

        // Array of lists for Adjacency List Representation 
        public Dictionary<int, List<int>> adj;
        public HashSet<int> visited;

        // Constructor 
       public Graph(int v)
        {
            visited = new HashSet<int>();
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

        public bool HasCycle(Graph g)
        {
            HashSet<int> greySet = new HashSet<int>();
            HashSet<int> whiteSet = new HashSet<int>();
            HashSet<int> blackSet = new HashSet<int>();

            foreach(int k in g.adj.Keys)
            {
                whiteSet.Add(k);
            }

            foreach (int current in whiteSet)
            {
                
               if( DFSDetectCycle(whiteSet,greySet,blackSet,current))
                {
                    return true;
                }

            }
            return false;
        }
        public static List<int> cycle = new List<int>();
        public static bool parentFound = false;
        public static int parent;
        private bool DFSDetectCycle(HashSet<int> whiteSet, HashSet<int> greySet, HashSet<int> blackSet, int current)
        {
            //move current from white to grey
            MoveNode(whiteSet, greySet, current);
            //go deeper for each neighbour of current
            foreach(int neighbour in adj[current])
            {
                //if that neighbour is in black set, return false
                if (blackSet.Contains(neighbour)) 
                    return false;                   
  
                //if that neighbour is in grey set, that mean it's we are examining the neighbour from some route and found it again, hence cycle.
                //return true. This is the end condition of the recursion.
                if (greySet.Contains(neighbour))
                {
                    cycle.Add(neighbour);
                    parent = neighbour;
                    return true;
                }

                //make a recursive call to the function here. Return true if the recursive call of this funcyion return true from any path
                if (DFSDetectCycle(whiteSet, greySet, blackSet, neighbour))
                {
                    if (neighbour == parent)
                    {
                        parentFound = true;
                    }
                    if(!parentFound)cycle.Add(neighbour);
                    return true;
                }
            }

            //after exiting the loop, we have been to the deepest possible nodes from the current node through all it's neighbours. 
            //We can now move this node from grey set to black set. This node is done.
            MoveNode(greySet, blackSet, current);

            //return false now as no cycle is detected.
            return false;

        }

        private void MoveNode(HashSet<int> sourceSet, HashSet<int> destinationSet, int node)
        {
            sourceSet.Remove(node);
            destinationSet.Add(node);
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
                Graph g = new Graph(5);

                g.addEdge(1,2);
                g.addEdge(2, 3);
                g.addEdge(3, 4);
                g.addEdge(4, 5);
                g.addEdge(5, 3);
               
                Console.WriteLine(g.HasCycle(g));

                //for this graph, cycle will have [0]=3, [1]=5, [2]=4. So print cycle in reverse order to get the cycle.
            }
            Console.ReadLine();
        }

    }
