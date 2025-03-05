using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class LinkedList
    {
        public ListNode CreateLinkedList(int[] linkedList)
        {
            ListNode head = new ListNode(linkedList[0]);
            ListNode current = head;

            for (int i = 1; i < linkedList.Length; i++)
            {
                ListNode newNode = new ListNode(linkedList[i]);
                current.next = newNode;
                current = current.next;
            }
            
            return head;
        }

        public void DisplayList(ListNode head)
        {
            for (ListNode current = head; current != null; current = current.next)
            {
                Console.Write(current.value + (current.next != null ? " -> " : ""));
            }

            Console.WriteLine();
        }

        public ListNode RemoveElements(ListNode head, int[] array)
        {
            var set = new HashSet<int>(array);

            for (ListNode current = head, prev = null; current != null; current = current.next)
            {
                if (set.Contains(current.value))
                {
                    if (prev != null) // more than one nodes
                    {
                        prev.next = current.next;
                    }
                    else // only one node
                    {
                        head = current.next;
                    }
                }
                prev = current;
                //else
                //{
                //    prev = current;
                //}
            }

            return head;
        }
    }
}
