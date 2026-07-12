public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        List<int> result = new List<int>();
        
        foreach(int num in nums1)
        {
            if(map.ContainsKey(num))
                map[num]++;
            else
                map[num] = 1;
        }
        
        foreach(int num in nums2)
        {
            if(map.ContainsKey(num) && map[num] > 0)
            {
                result.Add(num);
                map[num]--;
            }
        }
        
        return result.ToArray();
    }
}