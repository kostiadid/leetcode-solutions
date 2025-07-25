# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next

class Solution:
    def addTwoNumbers(self, l1: Optional[ListNode], l2: Optional[ListNode]) -> Optional[ListNode]:
        past = l1
        past1 = l2
        dummy = ListNode(0)
        current2 = dummy
        carry = 0

        while past is not None or past1 is not None or carry != 0:
            val1 = past.val if past is not None else 0
            val2 = past1.val if past1 is not None else 0
            summ = val1 + val2 + carry
            carry = summ // 10

            current2.next = ListNode(summ % 10)
            current2 = current2.next

            if past is not None:
                past = past.next
            if past1 is not None:
                past1 = past1.next

        return dummy.next
