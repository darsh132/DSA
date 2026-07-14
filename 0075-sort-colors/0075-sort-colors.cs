public class Solution {
    public void SortColors(int[] nums) {
        int low = 0;
        int mid = 0;
        int high = nums.Length - 1;

        while(mid <= high) {
            if(nums[mid] == 0) {
                // Swap the 0 to the low pointer position
                Swap(nums, low, mid);
                low++;
                mid++;
            } else if(nums[mid] == 1) {
                // 1s are already in the correct relative position (middle)
                mid++;
            } else if(nums[mid] == 2) {
                // Swap the 2 to the high pointer position
                Swap(nums, mid, high);
                high--;
                // Do not increment mid here because the swapped element from 'high' hasn't been evaluated yet.
            }
        }
    }

    private void Swap(int[] nums, int i, int j) {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}