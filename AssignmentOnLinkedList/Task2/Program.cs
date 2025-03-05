using Task2;

Console.Write("Enter size of the array: ");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];
Console.Write("Enter elements of the array: ");
string[] elements = Console.ReadLine().Split(' ');
for (int i = 0; i < n; i++)
{
    array[i] = int.Parse(elements[i]);
}

Console.Write("Enter size of the linked list: ");
int l = int.Parse(Console.ReadLine());
int[] linkedList = new int[l];
Console.Write("Enter elements of the linked list: ");
string[] listElements = Console.ReadLine().Split(' ');
for (int i = 0; i < n; i++)
{
    linkedList[i] = int.Parse(listElements[i]);
}

var ll = new LinkedList();
ListNode head = ll.CreateLinkedList(linkedList);
ll.DisplayList(head);
head = ll.RemoveElements(head, array);
ll.DisplayList(head);

