public class MinStack {
    Stack<int> mins;
    Stack<int> s; 

    public MinStack() {
        s = new Stack<int>();
        mins = new Stack<int>();  
    }
    
    public void Push(int val) {
        s.Push(val);
        if(mins.Count>0) val = Math.Min(val,mins.Peek());
        mins.Push(val);
    }
    
    public void Pop() {
        if(s.Count==0) return;
        s.Pop();
        mins.Pop();
    }
    
    public int Top() {
        return s.Peek();
    }
    
    public int GetMin() {
        return mins.Peek();
    }
}
