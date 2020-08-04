/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        Stack<ListNode> a = new Stack<ListNode>();
    Stack<ListNode> b = new Stack<ListNode>();
    ListNode ret = null;
    
    while(headA != null)
    {
        a.Push(headA);
        headA = headA.next;
    }
    while(headB != null)
    {
        b.Push(headB);
        headB = headB.next;
    }
    
    //if(a.Count() ==0 || b.Count()==0) return null;
    
    while((a.Count() >0 && b.Count()>0) && a.Peek() == b.Peek())
    {
        ret = a.Pop();
        b.Pop();
    }
    
    return ret;
}}