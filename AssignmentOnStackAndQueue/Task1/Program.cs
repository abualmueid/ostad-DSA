int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];
string[] input = Console.ReadLine().Split(' ');

for (int i = 0; i < n; i++)
{
    arr[i] = int.Parse(input[i]);
}

Queue<int> queue = new Queue<int>();

for (int i = 0; i < n; i++) 
{ 
    for (int j = i+1; j < n; j++)
    {
        if (arr[j] < arr[i])
        {
            queue.Enqueue(arr[j]);
            break;
        }
    }

    if (queue.Count == i)
    {
        queue.Enqueue(-1);
    }
}

foreach (var item in queue)
{
    Console.Write(item + " ");
}

Console.WriteLine();