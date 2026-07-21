public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        var result = new List<IList<int>>();
        if(nums == null || nums.Length < 3) return result;

        // Step 1: Sort the array
        Array.Sort(nums);

        for(int i = 0; i < nums.Length - 2; i++) {
            // Early exit: If the smallest number is greater than 0, 3 positive numbers can't sum to 0
            if(nums[i] > 0) break;

            // Skip duplicate values for the first element
            if(i > 0 && nums[i] == nums[i - 1]) continue;

            int left = i + 1;
            int right = nums.Length - 1;

            while(left < right) {
                int sum = nums[i] + nums[left] + nums[right];

                if(sum == 0) {
                    result.Add(new List<int> {nums[i], nums[left], nums[right]});

                    // Skip duplicates for the second element
                    while(left < right && nums[left] == nums[left + 1]) left++;
                    // Skip duplicates for the third element
                    while(left < right && nums[right] == nums[right - 1]) right--;

                    left++;
                    right--;
                }
                else if(sum < 0) {
                    left++; // Sum is too small, increase the left boundary
                }
                else {
                    right--; // Sum is too large, decrease the right boundary
                }
            }
        }

        return result;
    }
}