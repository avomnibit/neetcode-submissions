public class Solution {
    public int EvalRPN(string[] tokens) {
       Stack<int> q = new ();
       for (int i=0;i<tokens.Length;i++){
         if(tokens[i]=="+" || tokens[i]=="-" || tokens[i]=="*" || tokens[i]=="/"){
            getResult(q,tokens[i]);
            continue;
         }
         q.Push(int.Parse(tokens[i]));
       } 
       return q.Pop();
    }

    private void getResult(Stack<int> q, string op){
        int first = q.Pop();
            if(op=="+"){
                first=q.Pop()+first;
            }
            if(op=="-"){
                first=q.Pop()-first;
            }
            if(op=="/"){
                first=q.Pop()/first;
            }
            if(op=="*"){
                first=q.Pop()*first;
            }
        q.Push(first);
    }
}
