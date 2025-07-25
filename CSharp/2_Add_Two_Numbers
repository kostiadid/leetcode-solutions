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
        ListNode past = l1;
        // ListNode past = null;
        // ListNode next = null;
        // while(current!=null){
        //     next = current.next;
        //     current.next = past;
        //     past = current;
        //     current = next;
        // }

        ListNode past1 = l2;
        // ListNode past1 = null;
        // ListNode next1 = null;
        // while(current1!=null){
        //     next1 = current1.next;
        //     current1.next = past1;
        //     past1 = current1;
        //     current1 = next1;
        // }
        ListNode dummy = new ListNode(0);
        ListNode current2 = dummy;
        int carry = 0;

        while(past!=null || past1!=null || carry !=0){
            int val1 = past != null ? past.val : 0;
            int val2 = past1 != null ? past1.val : 0;
            int summ = val1 + val2 + carry;
            carry = summ/10;
            current2.next = new ListNode(summ%10);
            current2 = current2.next;
            if (past != null) past = past.next;
            if (past1 != null) past1 = past1.next; 

        } return dummy.next;
        

    }
}
