public class Solution {
    public int MaxArea(int[] height) {
        int maxArea =  0;
        int left = 0;
        int right = height.Length - 1;

        while(left < right) {
            // Calculate current width
            int width = right - left;

            // Calculate current area based on the shorter vertical line
            int currentArea = width * Math.Min(height[left], height[right]);

            // Update the maximum area seen so far
            maxArea = Math.Max(maxArea, currentArea);

            // Move the pointer that points to the lower line
            if(height[left] < height[right]) {
                left++;
            } else {
                right--;
            }
        }

        return maxArea;
    }
}