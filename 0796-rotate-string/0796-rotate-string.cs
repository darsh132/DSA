public class Solution {
    public bool RotateString(string s, string goal) {
        // If lengths differ, s can never become goal through shifts
        if(s.Length != goal.Length) {
            return false;
        }

        // Any valid cyclic shift of s is guaranteed to be a substring of s + s
        return (s + s).Contains(goal);
    }
}