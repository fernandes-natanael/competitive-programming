
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}


public class Solution {
    public ListNode ReverseList(ListNode head) {
        if (head is null) return head;
        ListNode list = new (head.val);     
        while(head.next != null)
        {
            head = head.next;
            ListNode newItem = new(head.val, list);
            list = newItem;
        }
        return list;
    }
}
