public class Solution {
    public int[] ReplaceElements(int[] arr) {
        int maxSoFar = -1;

        // Traverse the array from the last element to the first
        for(int i = arr.Length - 1; i >= 0; i--) {
            int current = arr[i];

            // Replace the current element with the maximum found to its right
            arr[i] = maxSoFar;

            // Update the maximum seen so far for the next elements to the left 
            if(current > maxSoFar) {
                maxSoFar = current;
            }
        }

        return arr;
    }
}