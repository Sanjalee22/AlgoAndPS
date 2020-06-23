//To find the cluster of 1s in a matrix of 0 and 1, we can do a DFS of all the connected 1s. and increase the count of the clusters.
class Program
    {

        static int[,] M;
        static bool[,] visited;
        static int totalRow, totalCol;
        public static void Main(string[] args)
        {
            int count;
            

            int noOfTC = Convert.ToInt32(Console.ReadLine());

            for (int t = 0; t < noOfTC; ++t)
            {
                ////int num = Convert.ToInt32(Console.ReadLine());
                //string[] s1 = Console.ReadLine().Split(' ');
                ////int[] arr = Array.ConvertAll(s1, int.Parse);
                ////string str = Console.ReadLine();
                //int i = 0; 
                visited = new bool[5, 5];
                totalRow = 5;
                totalCol = 5;
                M = new int[,] { { 1,1,0,0,0},
                                 { 0,1,1,0,1},
                                 { 0,0,0,0,1},
                                 {0,0,0,0,1 },
                                 {1,1,1,0,1 } };

                count = 0;
                for (int i = 0; i < totalRow; ++i)
                {
                    for (int j = 0; j < totalCol; ++j)
                    {
                        if (M[i, j] == 1 && !visited[i, j])
                        {
                            DFS(i, j);
                            count++;

                        }
                    }
                }
                Console.WriteLine(count);    
            }
            Console.ReadLine();
        }

        public static bool isSafe( int row, int col)
        {
            if (row >= 0 && row < totalRow && col >= 0 && col < totalCol && M[row, col] == 1 && !visited[row, col])
                return true;
            return false;
        }

        public static void DFS(int row, int col)
        {
            int[] rowNbr = new int[] { -1, -1, -1, 0, 0, 0, 1, 1, 1 };
            int[] colNbr = new int[] { -1, 0, 1, -1, 0, 1, -1, 0, 1 };

            visited[row, col] = true;

            for(int k = 0; k < 8; ++k)
            {
                if (isSafe(row + rowNbr[k], col + colNbr[k]))
                    DFS(row + rowNbr[k], col + colNbr[k]);
            }
        }

    }
