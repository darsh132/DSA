using System;
using System.Collections.Generic;

public class Solution 
{
    public int[] TwoSum(int[] nums, int target) 
    {
        // Key: The number itself, Value: The index of that number
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) 
        {
            int complement = target - nums[i];

            // If the complement is already in our dictionary, we found the pair
            if (map.ContainsKey(complement)) 
            {
                return new int[] { map[complement], i };
            }

            // Otherwise, store the current number and its index, handling duplicates safely
            if (!map.ContainsKey(nums[i]))
            {
                map.Add(nums[i], i);
            }
        }

        // Return an empty array if no solution is found (though problem statement assumes one exists)
        return new int[0];
    }
}
