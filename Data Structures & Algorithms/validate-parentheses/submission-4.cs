public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        stack.Push(s[0]);
        char aux;
        for(int i=1;i<s.Length;i++)
        {
            if(stack.TryPeek(out aux) && oposite(aux,s[i])){
                stack.Pop();
                continue;
            }
            stack.Push(s[i]);
        }
        return stack.Count == 0;
    }

    private bool oposite(char f, char s){
        if (f == '(' && s==')') return true;
        if (f == '{' && s=='}') return true;
        if (f == '[' && s==']') return true;
        return false;
    }
}
