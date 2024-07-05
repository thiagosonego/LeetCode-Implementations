public class Solution {
    public int Trap(int[] height) {
        int size = height.Length;
        if (size == 0) return 0;

        int[] l = new int[size];
        l[0] = height[0];
        for (int i = 1; i < size; i++) {
            l[i] = Math.Max(l[i - 1], height[i]);
        }

        int[] r = new int[size];
        r[size - 1] = height[size - 1];
        for (int i = size - 2; i >= 0; i--) {
            r[i] = Math.Max(r[i + 1], height[i]);
        }
        
        int totalWater = 0;

        for(int p = 0; p < size; p ++){
            totalWater += Math.Min(l[p], r[p]) - height[p];
        }

        return totalWater;
    }
}
