public class PrefixTree {
    private TreeNode root;

    public PrefixTree() {
        root = new TreeNode();
    }
    
    public void Insert(string word) {
        TreeNode current = root;
        int i;
        foreach(var c in word){
            i=c-'a';
            if(current.Children[i]==null) current.Children[i] = new TreeNode();
            current = current.Children[i];
        }
        current.IsEndOfWord=true;
    }
    
    public bool Search(string word) {
        TreeNode current = root;
        int i=0;
        foreach(var c in word){
            i=c-'a';
            if(current.Children[i]==null) return false;
            current = current.Children[i];
        }
        return current.IsEndOfWord;
    }
    
    public bool StartsWith(string prefix) {
        TreeNode current = root;
        int i=0;
        foreach(var c in prefix){
            i=c-'a';
            if(current.Children[i]==null) return false;
            current = current.Children[i];
        }
        return true;
    }
}

public class TreeNode{
    public TreeNode[] Children = new TreeNode[26];
    public bool IsEndOfWord = false;
} 