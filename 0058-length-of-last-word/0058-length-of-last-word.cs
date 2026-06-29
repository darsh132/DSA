public class Solution {
    public int LengthOfLastWord(string s) {
        string[] splittedString = s.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string lastWord = splittedString[splittedString.Length - 1];
        Console.WriteLine(lastWord);
        return lastWord.Length;
    }
}