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
    public bool HasCycle(ListNode head) {
        ListNode s1 = head, s2=head;
        while (s1?.next!=null && s2?.next?.next!=null){
            s1= s1.next;
            s2=s2.next.next;
            if(s1==s2) return true;
        }
        return false;
    }
}
