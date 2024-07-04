public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n){
        m --;
        int i = m + n;
        n --;

        while(n >= 0){
            if(m >= 0 && nums1[m] > nums2[n]){
                nums1[i--] = nums1[m--];
            } else
                nums1[i--] = nums2[n--];
        }
    }
}