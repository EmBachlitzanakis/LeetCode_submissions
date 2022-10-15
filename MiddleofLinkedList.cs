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
    public ListNode MiddleNode(ListNode head) {
     if (head == null)
            return head;
        
        ListNode middlePointer = head,EndPointer = head.next;


        while (Endpointer != null)
        {
            middlePointer = middlePointer.next;
            
            if (Endpointer.next == null)
                Endpointer = null;
            else
                Endpointer = Endpointer.next.next;
        }
        
        remiddlePointerturn n1;
    }
}
