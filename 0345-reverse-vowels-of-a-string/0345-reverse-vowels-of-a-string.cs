public class Solution {
    public string ReverseVowels(string s) {
        char[] chars = s.ToCharArray();
        int left = 0;
        int right = s.Length - 1;

        var vowels = "aeiouAEIOU";
        while(left < right)
        {
            while (left < right && vowels.IndexOf(chars[left]) == -1)
            {
                left++;
            }

            while(left < right && vowels.IndexOf(chars[right]) == -1)
            {
                right--;
            }

            if(left < right)
            {
                char temp = chars[left];
                chars[left] = chars[right];
                chars[right] = temp;

                left++;
                right--;
            }
        }

        return new string(chars);
    }
}