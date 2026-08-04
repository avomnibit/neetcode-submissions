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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        return add(l1,l2,0);
    }

    private ListNode add(ListNode l1, ListNode l2, int p){
        if(l1==null&l2==null&& p==0) return null;
        if(l1==null&l2==null&& p!=0) return new ListNode(p);
        int s=p;
        ListNode l1Next = null, l2Next=null;
        if(l1!=null) {s+=l1.val;l1Next = l1.next;}
        if(l2!=null) {s+=l2.val;l2Next = l2.next;}
        return new ListNode(s%10, add(l1Next, l2Next,s/10));
    }

}
