public class Program
{
    public static void Main()
    {
        int[][] land = new int[][]
        {
            new int[] { 1, 0, 0 },
            new int[] { 0, 1, 1 },
            new int[] { 0, 1, 1 }
        };
        
        Solution solution = new Solution();
        IList<int[]> groups = solution.FindFarmland(land);

        // Print the groups
        foreach (int[] group in groups)
        {
            Console.WriteLine($"[{group[0]}, {group[1]}, {group[2]}, {group[3]}]");
        }
    }
}