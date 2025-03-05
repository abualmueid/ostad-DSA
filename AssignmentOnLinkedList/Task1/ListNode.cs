using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class ListNode
    {
        public char value;
        public ListNode next;
        public ListNode prev;

        public ListNode(char value)
        {
            this.value = value;
            next = null;
            prev = null;
        }
    }
}
