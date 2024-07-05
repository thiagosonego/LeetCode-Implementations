public class Solution {
    public int Trap(int[] height) {
        int size = height.Length;
        if (size == 0) return 0;

        int highestValue = height[0];
        int highestIndex = 0;
        int tempWater = 0;
        int totalWater = 0;

        for(int i = 0; i < size; i++) {
            if(highestValue > height[i]) {
                tempWater += highestValue - height[i];
            }
            else {
                highestValue = height[i];
                highestIndex = i;
                totalWater += tempWater;
                tempWater = 0;
            }
        }

        highestValue = height[size - 1];
        tempWater = 0;

        for(int i = size -1; i >= highestIndex; i--) {
            if(highestValue > height[i]) {
                tempWater += highestValue - height[i];
            }
            else {
                highestValue = height[i];
                totalWater += tempWater;
                tempWater = 0;
            }
        }
        return totalWater;
    }
}