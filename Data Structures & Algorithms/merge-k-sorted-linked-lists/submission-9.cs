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
        while(true){
            min = new ListNode(int.MaxValue);
            index = -1;
            for(i=0;i<lists.Length;i++){
                if(lists[i]!=null && lists[i].val<min.val) { min = lists[i]; index = i; }
            }
            if (index==-1) break;
            if(result != null) result.next = min;
            else first = min;
            result = min;
            lists[index] = lists[index].next;
        }
        return first;
    }
}
