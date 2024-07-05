public class Solution {
    public int Trap(int[] height) {
        int n = height.Length;
        if (n == 0) return 0;

        int totalWater = 0;
        int[] l = GetHigherLeft(height, n);
        int[] r = GetHigherRight(height, n);

        for(int p = 0; p < n; p ++){
            totalWater += Math.Min(l[p], r[p]) - height[p];
        }
        return totalWater;
    }
    
    public int[] GetHigherLeft(int[] height, int size){
        int[] leftMax = new int[size];
        leftMax[0] = height[0];
        for (int i = 1; i < size; i++) {
            leftMax[i] = Math.Max(leftMax[i - 1], height[i]);
        }
        return leftMax;
    }

    public int[] GetHigherRight(int[] height, int size){
        int[] rightMax = new int[size];
        rightMax[size - 1] = height[size - 1];
        for (int i = size - 2; i >= 0; i--) {
            rightMax[i] = Math.Max(rightMax[i + 1], height[i]);
        }
        return rightMax;
    }
}