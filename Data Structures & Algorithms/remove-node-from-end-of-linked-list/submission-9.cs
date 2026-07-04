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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        if(head.next==null && n==1) return null; 
        ListNode aux = head, prev = head;
        int k=0;
        // 0 1 2
        // 0 2 4
        while(aux.next!=null) {
            aux = aux.next;
            k++;
        }
        if(k+1==n) return head.next;
        aux = head;
        k-=n;
        while(k>-1){
            prev = aux;
            aux = aux.next;
            k--;
        }
        prev.next=aux.next;
        return head;
    }
}
