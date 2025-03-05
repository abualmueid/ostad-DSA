using Task1;

int n = int.Parse(Console.ReadLine());

var llc = new LinkedListConverter();
ListNode head = llc.IntegerToDoublyLinkedList(n);
Console.Write("First function: "); 
llc.DisplayList(head);
Console.WriteLine();
Console.Write("Second function: ");
Console.WriteLine(llc.DoublyLinkedListToInteger(head));


