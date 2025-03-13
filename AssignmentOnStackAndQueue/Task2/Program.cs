int q = int.Parse(Console.ReadLine());

var stack1 = new Stack<int>();
var stack2 = new Stack<int>();
var queue = new Queue<int>();

for (int i = 0; i < q; i++)
{
    string[] input = Console.ReadLine().Split();

    if (input[0] == "1")
    {
        int x = int.Parse(input[1]);
        stack1.Push(x);
    }
    else if (input[0] == "2")
    {
        MoveItemFromStack1ToStack2();
        AddItemFromStack2ToQueue();
        DequeueAndShowFront();
    }
    else if (input[0] == "3")
    {
        MoveItemFromStack1ToStack2();
        AddItemFromStack2ToQueue();
        ShowFront();
    }
}
void MoveItemFromStack1ToStack2()
{
    if (stack2.Count == 0)
    {
        while (stack1.Count > 0)
        {
            stack2.Push(stack1.Pop());
        }
    }
}

void AddItemFromStack2ToQueue()
{
    while (stack2.Count > 0)
    {
        queue.Enqueue(stack2.Pop());
    }
}

void DequeueAndShowFront() 
{
    queue.Dequeue();

    if (queue.Count == 0)
        Console.WriteLine("-1");
    else
        Console.WriteLine(queue.Peek());
}

void ShowFront()
{
    if (queue.Count == 0)
        Console.WriteLine("-1");
    else
        Console.WriteLine(queue.Peek());
}