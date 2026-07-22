/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {    
     public ListNode MergeKLists(ListNode[] lists) {
        // 
        int i;
        ListNode result= null;
        ListNode first = null;
        ListNode min;
        int index;
        while(!completed(lists)){
            min = new ListNode(int.MaxValue);
            index = -1;
            for(i=0;i<lists.Length;i++){
                if(lists[i]!=null && lists[i].val<min.val) { min = lists[i]; index = i; }
            }
            if(result != null) result.next = min;
            else first = min;
            result = min;
            lists[index] = lists[index].next;
        }
        return first;
    }

    private bool completed(ListNode[] lists){
        if(lists==null || !lists.Any()) return true;
        for (int i=0; i< lists.Length;i++){
            if (lists[i]!= null) return false;
        }
        return true;
    }
}
