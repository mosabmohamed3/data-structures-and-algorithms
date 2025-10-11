public class Solution {
    public void ReorderList(ListNode head) {
         if (head == null || head.next == null)
            return;

        // Step 1: Find the middle
        ListNode slow = head, fast = head.next;
        while (fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }

        // Step 2: Reverse the second half
        ListNode prev = null, curr = slow.next;
        slow.next = null; // Split the list
        while (curr != null) {
            ListNode nextTemp = curr.next;
            curr.next = prev;
            
            prev = curr;
            curr = nextTemp;
        }

        // Step 3: Merge the two halves
        ListNode first = head, second = prev;
        while (second != null) {
            ListNode tmp1 = first.next;
            ListNode tmp2 = second.next;
            first.next = second;
            second.next = tmp1;
            first = tmp1;
            second = tmp2;
        }
    }
}