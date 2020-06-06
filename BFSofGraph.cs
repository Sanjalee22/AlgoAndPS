class Program
    {
        
        public static void Main(string[] args)
        {
            int noOfTC = Convert.ToInt32(Console.ReadLine());


            for (int t = 0; t < noOfTC; ++t)
            {
                //int num = Convert.ToInt32(Console.ReadLine());
                //string[] s1 = Console.ReadLine().Split(' ');
                //int[] startArray = Array.ConvertAll(s1, int.Parse);           


                //string str = Console.ReadLine();

                Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();


                //graph[0] = new List<int> { 0,1, 2, 3 };
                //graph[1] = new List<int> { 2, 4 };
                graph.Add(0, new List<int> { 1, 2, 3 });
                graph.Add(2, new List<int> { 4 });
                DFS(graph,0);
                Console.ReadLine();

                //Example graph:0->1,3,5,4 
                //1->2,0 
                //2-> 1,3 
                //3->0,2,5 | 4->0,5 | 5->0,3,4

            }
        }

        public static void BFS(Dictionary<int, List<int>> graph, int startnode)
        {
            Dictionary<int, bool> visited = new Dictionary<int, bool>();
            Queue<int> q = new Queue<int>();
            q.Enqueue(startnode);
            visited[startnode] = true;
                
            while(q.Count!=0)
            {
                int node = q.Dequeue();                
                visited.Add(node, true);
                //following condition so that you don't print what's already visited and has beed printed. Like when a queue is something like
                // 3,5,4,2,2,5. 
                
                if (!visited.ContainsKey(node)) 
                    Console.WriteLine(node);                
                
                if (graph.ContainsKey(node))
                {
                    foreach (int k in graph[node])
                        if (!visited[k]) //no point adding a node already visited.
                        {
                            q.Enqueue(k);
                        }
                }               
                
            }
            
        }

        


        

    }
