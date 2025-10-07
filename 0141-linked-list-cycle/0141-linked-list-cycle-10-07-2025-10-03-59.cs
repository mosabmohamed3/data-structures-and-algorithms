/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        HashSet<ListNode> hash = new HashSet<ListNode>();
        while(head != null)
        {
            if(hash.Contains(head))
                return true;
            else
                hash.Add(head);

            head = head.next;
        }

        return false;
    }
}