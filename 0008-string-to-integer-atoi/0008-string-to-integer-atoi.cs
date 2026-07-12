public class Solution {
    public int MyAtoi(string s) {
        int i = 0, sign = 1, res = 0;
        
        while (i < s.Length && s[i] == ' ') i++;
        
        if(i < s.Length && (s[i] == '-' || s[i] == '+'))
            sign = s[i++] == '-' ? -1 : 1;
        
        while(i < s.Length && char.IsDigit(s[i]))
        {
            int d = s[i++] - '0';
            
            if(res > (int.MaxValue -d) / 10)
                return sign == 1 ? int.MaxValue : int.MinValue;
            
            res = res * 10 + d;
        }
        
        return res * sign;
    }
}