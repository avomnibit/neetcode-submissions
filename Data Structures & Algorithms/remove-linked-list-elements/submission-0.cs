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
    public ListNode RemoveElements(ListNode head, int val) {
        ListNode c = head, prev = new ListNode(), first = prev;
        while(c!=null){
            if(c.val==val) { c=c.next; continue;}
            prev.next=c;
            prev = c;
            c = c.next;
        }
        prev.next = null;
        return  first.next;
    }
}