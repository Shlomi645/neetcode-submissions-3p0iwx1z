public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>();

        foreach (string token in tokens){
            if (token == "+" || token == "-" || token == "*" || token == "/"){
                int b = stack.Pop();
                int a = stack.Pop();
                int res = 0;
                if (token == "+"){
                    res = a + b;
                }
                else if(token == "-"){
                    res = a - b;
                }
                else if(token == "*"){
                    res = a*b;
                }
                else if(token == "/"){
                    res = a/b;
                }

                stack.Push(res);
            }
            else{
                stack.Push(int.Parse(token));
            }
        }
        return stack.Pop();
    }
}
