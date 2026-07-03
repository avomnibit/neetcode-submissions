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
        ListNode reversed = head;
        ListNode aux;
        if(head?.next==null) return reversed;
        ListNode current = head.next;
        reversed.next=null;
        while(current!=null){
            if(current.next!=null) {
                aux = current;
                current = current.next;
                aux.next = reversed;
                reversed = aux;
            } else {
                current.next = reversed;
                reversed = current;
                current = null;
            }
        }
        return reversed;
    }
}
