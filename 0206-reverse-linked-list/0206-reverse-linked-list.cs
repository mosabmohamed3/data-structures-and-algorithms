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
        if(head == null) return head;        
        
        ListNode prev_node = null;
        
        while(head != null){
            ListNode next_node = head.next;
            head.next = prev_node; 
            prev_node = head;
            head = next_node;        
        }
        
        return prev_node;
    }
}