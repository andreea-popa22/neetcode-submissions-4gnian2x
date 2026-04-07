public class Solution {
    public bool IsPalindrome(string s) {
        var left = 0;
        var right = s.Length - 1;
        while (left < right){
            if (!Char.IsLetterOrDigit(s[left])) {
                left += 1;
                continue;
            }
            if (!Char.IsLetterOrDigit(s[right])) {
                right -= 1;
                continue;
            }
            if (Char.ToLower(s[left]) != Char.ToLower(s[right])) {
                return false;
            }

            left += 1;
            right -= 1;
        }
        return true;
    }
}
