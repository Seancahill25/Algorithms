using System;

// Definition for singly-linked list:
// class ListNode<T> {
//   public T value { get; set; }
//   public ListNode<T> next { get; set; }
// }

public class Class1
{
	public Class1()
	{
        ListNode<int> removeKFromList(ListNode<int> l, int k)
        {
            if (l == null)
            {
                return null;
            }
            if (l.value != k)
            {
                l.next = removeKFromList(l.next, k);
            }
            else
            {
                l = removeKFromList(l.next, k);
            }
            return l;
        }
    }
}
