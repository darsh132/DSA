public class Solution {
    public string ReverseWords(string s) {
        StringBuilder strB = new StringBuilder();
        var res = s.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine(res.Length - 1);
        for(int i = res.Length - 1; i >= 0; i--)
        {
            strB.Append($"{res[i]}");
            if (i > 0) {
                strB.Append(" ");
            }
        }
        foreach(var c in res)
        {
            Console.WriteLine(c);
        }

        return strB.ToString().Trim();
    }
}