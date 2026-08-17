public class WordDictionary {
    public  class TreeNode{
        public char? Ch;
        public Dictionary<char,TreeNode> Children;
        public TreeNode(char? c){
            Ch = c;
            Children=new();
        }
    }

    private TreeNode root;


    public WordDictionary() {
        root = new TreeNode(null);
    }
    
    public void AddWord(string word) {
        TreeNode c= root;
        for(int i=0;i<word.Length;i++){
            if(!c.Children.ContainsKey(word[i])) {
                c.Children.Add(word[i],new TreeNode(word[i]));
            }
            c = c.Children[word[i]];
        }
        if(!c.Children.ContainsKey('/')) c.Children.Add('/',new TreeNode('/'));
    }
    
    public bool Search(string word) {
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        int i,size, index=0;
        TreeNode aux;
        while(index<word.Length && q.Count>0){
            size = q.Count; 
            for(i=0;i<size;i++){
                aux = q.Dequeue();
                if(word[index]=='.'){
                    foreach(var ch in aux.Children.Keys){
                        if (ch != '/') q.Enqueue(aux.Children[ch]);
                    }
                } else if(aux.Children.ContainsKey(word[index])) q.Enqueue(aux.Children[word[index]]);
            }
            index++;
        }
        for(i=0;i<q.Count;i++){
            aux = q.Dequeue();
            if(aux.Children.ContainsKey('/')) return true;
        }
        return false;
    }
}
