class Solution {
    
        public bool solve(int A, List<List<int>> B)
        {
            Dictionary<int, bool> visited;
            Dictionary<int, int> parent;
            Dictionary<int, List<int>> adj;
            bool cycleFound;
            visited = new Dictionary<int, bool>();
            adj = new Dictionary<int, List<int>>();
            cycleFound = false;
            parent = new Dictionary<int, int>();

            foreach (List<int> l in B)
            {
                if (!adj.ContainsKey(l[0]))
                {
                    adj.Add(l[0], new List<int>());
                }

                adj[l[0]].Add(l[1]);


            }

            foreach (KeyValuePair<int, List<int>> kvp in adj)
            {
                if (!visited.ContainsKey(kvp.Key))
                {
                    if (cycleFound)
                        break;
                    BFS(kvp.Key, visited, adj, parent, ref cycleFound);
                }
            }
            return cycleFound;

        }

        public static void BFS(int start, Dictionary<int, bool> visited, 
        Dictionary<int, List<int>> adj,Dictionary<int, int> parent, ref bool cycleFound )
        {
            Queue<int> queue = new Queue<int>();
            visited.Add(start, true);
            queue.Enqueue(start);
            while (queue.Count != 0)
            {
                if (cycleFound)
                    break;
                int temp = queue.Dequeue();
                if(!adj.ContainsKey(temp)) break;
                foreach (int x in adj[temp])
                {
                    if (visited.ContainsKey(x) && (parent.ContainsKey(temp) && parent[temp] != x))
                    {
                        cycleFound = true;
                        break;
                    }
                    else
                    {
                        queue.Enqueue(x);
                        visited.Add(x, true);
                        if (!parent.ContainsKey(x))
                            parent.Add(x, -1);
                        parent[x] = temp;
                    }

                }
            }
        }
}
