public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
       // Base case: if the array is empty, return an empty list
       if(strs == null || strs.Length == 0) {
        return new List<IList<string>>();
       } 

       // Dictionary to group original strings by their sorted version
       Dictionary<string, List<string>> groups = new Dictionary<string, List<string>>();

        foreach(string s in strs) {
          // Convert string to character array, sort it, and convert back to string
          char[] charArray = s.ToCharArray();
          Array.Sort(charArray);
          string sortedKey = new string(charArray);

          // If the key doesn't exist, initialize a new list
          if(!groups.ContainsKey(sortedKey)) {
            groups[sortedKey] = new List<string>();
          }

          // Add the original string to the matching group
          groups[sortedKey].Add(s);
        }

        // Return the values of the dictionary cast to the required return type
        return groups.Values.Cast<IList<string>>().ToList();
    }
}