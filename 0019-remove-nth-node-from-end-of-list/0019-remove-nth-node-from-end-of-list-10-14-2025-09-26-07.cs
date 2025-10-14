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
        ListNode dummy = new ListNode(0, head);
        int length = 0;
        ListNode current = head;

        while(current != null)
        {
            length++;
            current = current.next;
        }

        current = dummy;
        for(int i = 0; i < length - n; i++)
        {
            current = current.next;
        }

        current.next = current.next.next;

        return dummy.next;

        // var dummy = new ListNode(0, head);
        // var first = dummy;
        // var second = dummy;

        // // Move first ahead by n + 1 steps
        // for (int i = 0; i <= n; i++)
        //     first = first.next;

        // // Move both until first hits end
        // while (first != null)
        // {
        //     first = first.next;
        //     second = second.next;
        // }

        // // Delete the nth node from end
        // second.next = second.next.next;

        // return dummy.next;
    }
}