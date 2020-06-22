public void DFSUtilDetectCycle(int parent, int current, bool cycleFound)
        {
            // Mark the current node as visited and print it 
            visited.Add(current);
            //Console.Write(v + " ");

            // Recur for all the vertices adjacent to this vertex 
            foreach (int i in adj[current])
            {
                if (i != parent && visited.Contains(i))
                {
                    cycleFound = true;

                }
                if (!visited.Contains(i))
                   DFSUtilDetectCycle(current, i, cycleFound);
            }

            
        }  
