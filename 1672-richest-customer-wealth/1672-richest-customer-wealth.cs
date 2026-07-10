public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int maxwealth = 0;

        foreach(var customer in accounts)
        {
            int wealth = 0;
            foreach(var bank in customer)
            {
                wealth += bank;
            }
            if(wealth > maxwealth)
            {
                maxwealth = wealth;
            }
        }

        return maxwealth;
    }
}