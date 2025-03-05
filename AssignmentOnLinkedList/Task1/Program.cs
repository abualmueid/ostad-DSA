using Task1;

int n = int.Parse(Console.ReadLine());

ListNode head = IntegerToDoublyLinkedList(n);
Console.Write("First function: "); 
DisplayList(head);
Console.WriteLine();
Console.Write("Second function: ");
Console.WriteLine(DoublyLinkedListToInteger(head));

ListNode IntegerToDoublyLinkedList(int n)
{ 
    string s = n.ToString();
    ListNode head = new ListNode(s[0]);
    ListNode current = head;

    for (int i = 1; i < s.Length; i++) 
    {
        ListNode newNode = new ListNode(s[i]);
        current.next = newNode;
        newNode.prev = current;
        current = current.next;
    }

    return head;
}

void DisplayList(ListNode head) 
{
    for (ListNode current = head; current != null; current = current.next)
    {
        Console.Write(current.value);
        if (current.next != null)
            Console.Write(" <-> ");
    }
}

int DoublyLinkedListToInteger(ListNode head) 
{
    string s = "";

    for (ListNode current = head; current != null; current = current.next)
    {
        s += current.value;
    }

    return int.Parse(s);
}






