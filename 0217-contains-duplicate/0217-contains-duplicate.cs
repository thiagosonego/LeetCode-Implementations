public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        for(int i = 0; i < nums.Length; i++){
            int test = nums[i];
            for(int j = i + 1; j < nums.Length; j++){
                if(nums[j] == test)
                    return true;
            }
        }
        return false;
    }
}