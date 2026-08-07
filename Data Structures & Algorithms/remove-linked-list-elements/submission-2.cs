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
        var first = new ListNode(-1,head);
        var c = first;
        while(c.next!=null){
            if(c.next.val==val){
                c.next = c.next.next;
            } else {
                c = c.next;
            }
        }

        return first.next;
    }
}