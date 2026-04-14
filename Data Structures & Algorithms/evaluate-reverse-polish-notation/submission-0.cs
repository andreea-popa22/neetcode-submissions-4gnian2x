public class Solution {
    public bool IsOperator(string s){
        if (s == "+" || s == "-" || s == "*" || s == "/") {
            return true;
        }
        return false;
    }

    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>();
        
        foreach (var token in tokens) {
            if (IsOperator(token)) {
                int right = stack.Pop();
                int left = stack.Pop();

                int res = 0;

                switch (token) {
                    case "+":
                        res = left + right;
                        break;
                    case "-":
                        res = left - right;
                        break;
                    case "*":
                        res = left * right;
                        break;
                    case "/":
                        res = left / right;
                        break;
                }

                stack.Push(res);
            }
            else {
                stack.Push(int.Parse(token));
            }
        }

        return stack.Pop();
    }
}
