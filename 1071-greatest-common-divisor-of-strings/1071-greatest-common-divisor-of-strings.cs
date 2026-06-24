public class Solution {
    public string GcdOfStrings(string str1, string str2) {
       // Step 1: Check if a common divisor string can even exist
       if(str1 + str2 != str2 + str1)
       {
            return "";
       }

       // Step 2: Find the GCD of the lengths of both strings
       int gcdLength = GetGcd(str1.Length, str2.Length);

       // Step 3: Return the prefix substring of that length
       return str1.Substring(0, gcdLength);
    }

    // Helper methood to compute GCD using Euclidean algorithm
    private int GetGcd(int a, int b)
    {
        while (b != 0){
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}