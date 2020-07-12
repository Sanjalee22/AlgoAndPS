//Given a n*n matrix where all numbers are distinct, find the maximum length path (starting from any cell) such that all cells along the path are in increasing order 
//with a difference of 1.

//We can move in 4 directions from a given cell (i, j), i.e., we can move to (i+1, j) or (i, j+1) or (i-1, j) or (i, j-1) with the condition that the adjacent 
//cells have a difference of 1.
class Program
        {

            public static void Main(string[] args)
            {
                int noOfTC = Convert.ToInt32(Console.ReadLine());

            for (int t = 0; t < noOfTC; ++t)
            {
                //int num = Convert.ToInt32(Console.ReadLine());
                //string[] s1 = Console.ReadLine().Split(' ');
                ////int[] arr = Array.ConvertAll(s1, int.Parse);
                ////string str = Console.ReadLine();
                //int i = 0; 

                int[][] mat = new int[][] {
                                    new int[] { 1, 2, 9 },
                                    new int[] { 5, 3, 8 },
                                    new int[] { 4, 6, 7 }
                                    };

                int n = 3;
                int[,] dp = new int[n,n];

                
                for (int i = 0; i < n; ++i)
                {
                    for(int j=0;j<n;++j)
                    {
                        dp[i,j] = -1;
                    }
                }
                        
                int result = 0;
                for(int i=0;i<n;++i)
                {
                    for(int j=0;j<n;++j)
                    {
                        result = Math.Max(result, getLongestPathFromCell(i, j, n, mat, dp));
                    }
                }
                Console.WriteLine(result);
                }
                Console.ReadLine();
            }

        public static int getLongestPathFromCell(int i, int j, int n, int[][] mat, int[,] dp)
        {
            // Check if i and j are valid
            if (i < 0 || i >= n || j < 0 || j >= n)
                return 0;

            //Check if this cell has already been solved
            if (dp[i,j] != -1)
                return dp[i,j];

            //now get the max path length starting from this cell and checking in all directions
            //if that direction exists
            int w = -1; int x = -1; int y = -1; int z = -1;

            // direction i, j+1
            if (j < n - 1 && mat[i][j + 1] == mat[i][j] + 1)
                w = 1 + getLongestPathFromCell(i, j + 1, n, mat, dp);

            //Direction i, j-1
            if (j > 0 && mat[i][j -1] == mat[i][j] + 1)
                x = 1 + getLongestPathFromCell(i, j - 1, n, mat, dp);

            //Direction i-1, j
            if (i > 0 && mat[i-1][j] == mat[i][j] + 1)
                y = 1 + getLongestPathFromCell(i-1, j, n, mat, dp);

            //Direction i+1,j
            if (i < n-1 && mat[i+1][j] == mat[i][j] + 1)
                z = 1 + getLongestPathFromCell(i+1, j, n, mat, dp);

            dp[i,j] = Math.Max(w, Math.Max(x, Math.Max(y,Math.Max(1, z))));
            return dp[i,j];           


        }

        }
