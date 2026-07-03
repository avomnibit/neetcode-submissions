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
    public ListNode ReverseList(ListNode head) {
        ListNode current = head;
        ListNode prev=null;
        while(current!=null){
            ListNode aux = current;
            current = current.next;
            aux.next = prev;
            prev = aux;
        }
        return prev;
    }
}
