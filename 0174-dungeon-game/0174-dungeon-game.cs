public class Solution {
    public int CalculateMinimumHP(int[][] dungeon) {
        int rows = dungeon.Length, cols = dungeon[0].Length;
        int[] cache = new int[cols+1];

        Array.Fill(cache, int.MaxValue);

        cache[cols-1] = 1;

        for(int r = rows -1; r >= 0; r--){
            for(int c = cols -1; c >= 0; c --){
                var bottomPathCost = cache[c];
                var rightPathCost = cache[c+1];

                var minPowerReq = Math.Min(bottomPathCost, rightPathCost)-dungeon[r][c];
                cache[c] = Math.Max(1,minPowerReq);
            }
        }

        return cache[0];
    }
}