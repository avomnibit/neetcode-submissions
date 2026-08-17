/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        if(node == null) return null;
        Dictionary<int,Node> map = new();
        Queue<Node> s = new();
        s.Enqueue(node);
        Node aux,newN;
        while(s.Count>0){
            aux=s.Dequeue();
            if(!map.ContainsKey(aux.val)) map.Add(aux.val, new Node(aux.val));
            newN = map[aux.val];
            foreach(var n in aux.neighbors){
                if(!map.ContainsKey(n.val)) {
                    map.Add(n.val, new Node(n.val));
                    s.Enqueue(n);
                }
                newN.neighbors.Add(map[n.val]);
            }
        }
        return map[1];
    }
}
