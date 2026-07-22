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
        PriorityQueue<int,int> pq = new PriorityQueue<int,int>();
        ListNode result = new ListNode(0);
        ListNode c = result;
        for(int i = 0;i<lists.Length;i++){
            while(lists[i]!=null){
                pq.Enqueue(lists[i].val,lists[i].val);
                lists[i] = lists[i].next;
            }
        }
        int aux;
        while(pq.Count>0){
            aux = pq.Dequeue();
            c.next = new ListNode(aux);
            c = c.next;
        }
        return result.next;
    }
}
