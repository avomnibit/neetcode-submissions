public class Solution {
    public int EvalRPN(string[] tokens) {
       Stack<int> q = new ();
       for (int i=0;i<tokens.Length;i++){
         if(tokens[i]=="+" || tokens[i]=="-" || tokens[i]=="*" || tokens[i]=="/"){
            int first = q.Pop();
            if(tokens[i]=="+"){
                first=q.Pop()+first;
            }
            if(tokens[i]=="-"){
                first=q.Pop()-first;
            }
            if(tokens[i]=="/"){
                first=q.Pop()/first;
            }
            if(tokens[i]=="*"){
                first=q.Pop()*first;
            }
        q.Push(first);
            continue;
         }
         q.Push(int.Parse(tokens[i]));
       } 
       return q.Pop();
    }
}
