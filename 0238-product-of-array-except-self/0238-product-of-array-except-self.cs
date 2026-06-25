public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] result = new int[n];

        // Step 1: Calculate prefix products (products of all elements to the left)
        result[0] = 1; // There are no elements to the left of index 0
        for(int i = 1; i < n; i++)
        {
            result[i] = result[i - 1] * nums[i - 1];
        }

        // Step 2: Calculate suffix products on the fly and multiply into the result
        int rightProduct = 1;
        for(int i = n - 1; i >= 0; i--)
        {
            result[i] *= rightProduct;
            rightProduct *= nums[i]; // Update the running suffix product
        }

        return result;
    }
}