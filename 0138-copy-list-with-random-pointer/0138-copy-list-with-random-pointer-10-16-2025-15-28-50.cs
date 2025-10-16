/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node CopyRandomList(Node head) {
        Dictionary<Node, Node> oldToNew = new Dictionary<Node, Node>();

        Node cur = head;
        while(cur != null)
        {
            Node newNode = new Node(cur.val);
            oldToNew[cur] = newNode;
            cur = cur.next;
        }

        cur = head;
        while(cur != null)
        {
            oldToNew[cur].next = cur.next != null ? oldToNew[cur.next] : null;
            oldToNew[cur].random = cur.random != null ? oldToNew[cur.random] : null;
            cur = cur.next;
        }

        return head != null ? oldToNew[head] : null;
    }
}