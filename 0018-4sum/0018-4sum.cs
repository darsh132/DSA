public class Solution {
    public IList<IList<int>> FourSum(int[] nums, int target) {
        var result = new List<IList<int>>();
        if(nums == null || nums.Length < 4) return result;

        // 1. Sort the array to handle duplicates and use two pointers
        Array.Sort(nums);
        int n = nums.Length;

        // 2. First pointer (i)
        for(int i = 0; i < n - 3; i++) {
            // Skip duplicate values for the first element
            if(i > 0 && nums[i] == nums[i - 1]) continue;

            // 3. Second pointer (j)
            for(int j = i + 1; j < n - 2; j++) {
                // Skip duplicate values for the second element
                if(j > i + 1 && nums[j] == nums[j - 1]) continue;

                // 4. Two-pointer approach for the remaining two elements 
                int left = j + 1;
                int right = n - 1;

                while(left < right) {
                    // Use long to prevent integer overflow from large test cases
                    long sum = (long)nums[i] + nums[j] + nums[left] + nums[right];

                    if(sum == target) {
                        result.Add(new List<int> { nums[i], nums[j], nums[left], nums[right] });

                        // Skip duplicates for the third element
                        while(left < right && nums[left] == nums[left + 1]) left++;
                        // Skip duplicates for the fourth element
                        while(left < right && nums[right] == nums[right - 1]) right--;

                        left++;
                        right--;
                    }
                    else if(sum < target) {
                        left++; // Sum is too small, move
                    }
                    else {
                        right--; // Sum is too large, move leftward
                    }
                }

            }
        }

        return result;
    }
}