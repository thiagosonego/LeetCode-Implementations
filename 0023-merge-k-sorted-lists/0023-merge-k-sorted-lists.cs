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
    public ListNode MergeKLists(ListNode[] lists) {
        if(lists.Length == 0)
            return null;
        
        return MergeKListsInternal(lists, 0,lists.Length -1);
    }

    private ListNode MergeKListsInternal(ListNode[] lists, int l, int r){
        if(l == r){
            return lists[l];
        } else {
            var mid = (l + r) / 2;
            var l1 = MergeKListsInternal(lists, l, mid);
            var l2 = MergeKListsInternal(lists, mid+1, r);
            return MergeTwoLists(l1, l2);
        }
    }

    private ListNode MergeTwoLists(ListNode list1, ListNode list2){
        if(list1 == null)
            return list2;
        if(list2 == null)
            return list1;
        
        var head = new ListNode();
        var currentNode = head;

        while(list1 != null && list2 != null){
            if(list1.val < list2.val){
                currentNode.next = list1;
                list1 = list1.next;
            } else {
                currentNode.next = list2;
                list2 = list2.next;
            }

            currentNode = currentNode.next;
        }

        if(list1 != null)
            currentNode.next = list1;

        if(list2 != null)
            currentNode.next = list2;

        return head.next;
    }
}