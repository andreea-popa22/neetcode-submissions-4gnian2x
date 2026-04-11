public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        Dictionary<char, char> closeToOpenBrackets = new Dictionary<char, char> {
            {')', '('},
            {']', '['},
            {'}', '{'}
        };

        foreach (char c in s){
            if (closeToOpenBrackets.ContainsKey(c)) {
                if (stack.Count > 0 && stack.Peek() == closeToOpenBrackets[c]){
                    stack.Pop();
                }
                else{
                    return false;
                }
            }
            else {
                stack.Push(c);
            }
        }

        if (stack.Count != 0) {
            return false;
        }

        return true;
    }
}
