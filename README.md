# Intuition
To identify groups of farmland in a binary matrix (land), you can traverse the matrix and look for contiguous areas of farmland (1s) that form rectangular regions. The task involves exploring these groups and determining their boundaries.

# Approach
1. Traversal: Use nested loops to traverse the binary matrix (land).
2. Group Identification: When a farmland (1) is found, begin exploring the extent of the group.
3. Depth-First Search: A helper function, Dfs, performs depth-first search (DFS) to explore the group, mark the visited cells, and determine the bottom-right corner of the group.
4. Record Coordinates: Store the top-left and bottom-right coordinates of the group in a list of groups.
5. Convert to Array: Convert the list of groups to a 2D array (int[][]) before returning the result.
# Complexity
- Time complexity: The time complexity of the algorithm is O(m×n), where m and n are the number of rows and columns in the matrix, respectively. This is because every cell in the matrix is traversed once, and each cell that is part of a group of farmland is explored once during the DFS process.
- Space complexity: The space complexity of the algorithm is O(1), because the function uses only a constant amount of extra space (e.g., for variables like the list of groups and the DFS stack). The land matrix is modified in place, so the function does not require additional space for data structures proportional to the size of the matrix.
