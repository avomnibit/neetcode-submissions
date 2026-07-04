public class Solution {
    public void ReorderList(ListNode head) {
        if(head==null) return;
        List<ListNode> list= new List<ListNode>();
        ListNode c = head;
        while(c!=null) {list.Add(c); c=c.next;}
        int l=0,r=list.Count-1;
        while(l<r){
            list[l].next=list[r];
            l++;
            if (l == r) break;
            list[r].next=list[l];
            r--;
        }
        list[l].next = null;
    }
}