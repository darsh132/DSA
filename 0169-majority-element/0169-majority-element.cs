public class Solution {
    public int MajorityElement(int[] nums) {
        int candidate = 0;
        int count = 0;

        foreach(int num in nums) {
            // If count reaches 0, we pick the current number as our new candidate
            if(count == 0) {
                candidate = num;
            }

            // If the current number matches the candidate, increment count; otherwise, decrement it
            count += (num == candidate) ? 1 : -1;
        }

        return candidate;
    }
}