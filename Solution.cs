using System;
using System.Collections.Generic;

public class Solution
{
    public IList<int[]> FindFarmland(int[][] land)
    {
        int m = land.Length;
        int n = land[0].Length;
        List<int[]> groups = new List<int[]>();
        
        // Helper function to perform DFS and mark the group visited
        void Dfs(int r, int c, ref int bottomRightR, ref int bottomRightC)
        {
            // Boundary check and stop if it's not a 1
            if (r < 0 || r >= m || c < 0 || c >= n || land[r][c] != 1)
            {
                return;
            }

            // Update bottom-right corner coordinates
            bottomRightR = Math.Max(bottomRightR, r);
            bottomRightC = Math.Max(bottomRightC, c);

            // Mark the cell as visited
            land[r][c] = 0;

            // Explore the adjacent cells (right and down only)
            Dfs(r + 1, c, ref bottomRightR, ref bottomRightC);
            Dfs(r, c + 1, ref bottomRightR, ref bottomRightC);
        }
        
        // Traverse the land matrix
        for (int r = 0; r < m; r++)
        {
            for (int c = 0; c < n; c++)
            {
                // If we find a farmland (1), start exploring the group
                if (land[r][c] == 1)
                {
                    int bottomRightR = r;
                    int bottomRightC = c;
                    
                    // Perform DFS to find the extent of the group
                    Dfs(r, c, ref bottomRightR, ref bottomRightC);
                    
                    // Add the group coordinates to the list
                    groups.Add(new int[] { r, c, bottomRightR, bottomRightC });
                }
            }
        }

        return groups;
    }
}
