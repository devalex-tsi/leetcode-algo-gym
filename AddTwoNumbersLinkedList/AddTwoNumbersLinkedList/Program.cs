//Add Two Numbers
//https://leetcode.com/problems/add-two-numbers
//You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.

//You may assume the two numbers do not contain any leading zero, except the number 0 itself. 

//Example 1:
//Input: l1 = [2,4,3], l2 = [5,6,4]
//Output: [7,0,8]
//Explanation: 342 + 465 = 807.

//Example 2:
//Input: l1 = [0], l2 = [0]
//Output: [0]

//Example 3:
//Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
//Output: [8,9,9,9,0,0,0,1]

//Constraints:
//The number of nodes in each linked list is in the range [1, 100].
//0 <= Node.val <= 9
//It is guaranteed that the list represents a number that does not have leading zeros.Add Two Numbers


Console.WriteLine("Hello, World!");

var l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
var l2 = new ListNode(5, new ListNode(6, new ListNode(4)));

var inverted = AddTwoNumbers(l1, l2);

ListNode AddTwoNumbers(ListNode l1, ListNode l2)
{
    var head = new ListNode();
    var result = head;
    var carry = 0;
    while (l1 != null || l2 != null)
    {
        var temp = (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val) + carry;

        result.val = temp % 10;
        carry = temp / 10;

        l1 = l1?.next;
        l2 = l2?.next;

        if (l1 == null && l2 == null && carry == 1)
        {
            result.next = new ListNode { val = carry };
            break;
        }
        if (l1 == null && l2 == null && carry == 0)
        {
            break;
        }

        result.next = new ListNode();
        result = result.next;
    }

    return head;
}


public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
