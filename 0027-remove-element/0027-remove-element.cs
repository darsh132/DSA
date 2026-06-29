public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int k = 0; // Pointer for the next valid element position

        for(int i = 0; i < nums.Length; i++) {
            if(nums[i] != val) {
                nums[k] = nums[i];
                k++;
            }
        }

        return k; // k represents the count of elements not equal to val
    }
}