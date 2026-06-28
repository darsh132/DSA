public class Solution {
    public int MaximumElementAfterDecrementingAndRearranging(int[] arr) {
        // Step 1: Sort the array to process elements in increasing order
        Array.Sort(arr);

        // Step 2: The first element must be 1
        arr[0] = 1;

        // Step 3: Iterate through  the array and apply the greedy constraint
        for(int i = 1; i < arr.Length; i++) {
            if(arr[i] - arr[i - 1] > 1)
            {
                arr[i] = arr[i - 1] + 1;
            }
        }

        // The last element will hold the maximum possible value
        return arr[arr.Length - 1];
    }
}