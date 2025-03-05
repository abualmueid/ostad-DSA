using Task1;

int n = int.Parse(Console.ReadLine());

var ll = new LinkedList();
ListNode head = ll.IntegerToDoublyLinkedList(n);
Console.Write("First function: "); 
ll.DisplayList(head);
Console.WriteLine();
Console.Write("Second function: ");
Console.WriteLine(ll.DoublyLinkedListToInteger(head));


