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
        // A dummy head helps us easily build and return the new linked list   
        ListNode dummyHead = new ListNode(0);
        ListNode current = dummyHead;
        int carry = 0;

        // Loop runs as long as there are digits left in either list, or a leftover carry
        while(l1 != null || l2 != null || carry != 0)
        {
            int sum = carry;

            // If l1 still has digits, add its value and move the next node
            if(l1 != null) {
                sum += l1.val;
                l1 = l1.next;
            }

            // if l2 still has digits, add its value and move the next node
            if(l2 != null){
                sum += l2.val;
                l2 = l2.next;
            }

            // Calculate the new carry (either 0 or 1)
            carry = sum / 10;

            // Create a new node with the single-digit remainder (sum % 10)
            current.next = new ListNode(sum % 10);
            current = current.next;
        }

        // The actual result list starts right after our dummy placeholder
        return dummyHead.next;
    }
}