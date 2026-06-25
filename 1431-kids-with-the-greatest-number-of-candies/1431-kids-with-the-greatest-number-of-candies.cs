public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        int max = candies.Max(); 
        int sum = 0;
        List<bool> boolList = new List<bool> { };
        for(int i = 0; i < candies.Length; i++)
        {
            sum = candies[i] + extraCandies;
            if(sum >= max)
            {
                boolList.Add(true);
            }
            else
            {
                boolList.Add(false);
            }
        }

        return boolList;
    }
}