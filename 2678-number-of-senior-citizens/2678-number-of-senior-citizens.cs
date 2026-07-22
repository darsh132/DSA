public class Solution {
    public int CountSeniors(string[] details) {
        int seniorCount = 0;

        foreach(string passenger in details) {
            // Extract the tens and ones place digits of the age from indices 11 and 12
            int age = (passenger[11] - '0') * 10 + (passenger[12] - '0');

            // Check if the passenger is strictly older than 60
            if(age > 60) {
                seniorCount++;
            }
        }

        return seniorCount;
    }
}