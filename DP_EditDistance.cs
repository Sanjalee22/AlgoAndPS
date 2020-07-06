//Refer this link for explanatin: https://algorithms.tutorialhorizon.com/dynamic-programming-edit-distance-problem/
//My leetcode solution: https://leetcode.com/problems/edit-distance/submissions/
public class Solution {
    public int MinDistance(string word1, string word2) {
      int[,] solution = new int[word1.Length + 1,word2.Length + 1];

            int m = word1.Length;
            int n = word2.Length;
            for (int i=0;i<=n;++i)
            {
                solution[0, i] = i;
            }

            for(int j=0;j<=m;++j)
            {
                solution[j, 0] = j;
            }

            for(int i=1;i<=m;++i)
            {
                for(int j=1;j<=n;++j)
                {
                    if (word1[i-1] == word2[j-1])
                        solution[i, j] = solution[i - 1, j - 1];
                    else
                        solution[i, j] = 1 + Math.Min(solution[i, j - 1],Math.Min( solution[i - 1, j], solution[i - 1, j - 1]));
                }
            }

            return solution[m, n];  
    }
}
