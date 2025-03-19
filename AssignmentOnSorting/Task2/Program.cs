string[] input = Console.ReadLine().Split();
int n = int.Parse(input[0]);
int m = int.Parse(input[1]);

int[] arr = new int[n];
string[] input2 = Console.ReadLine().Split();
for (int i = 0; i < n; i++)
{
    arr[i] = int.Parse(input2[i]);
}

var lists = new List<string>();
for (int i = 0; i < m; i++)
{
    string[] query = Console.ReadLine().Split();
    int index = int.Parse(query[0]) - 1;
    arr[index] += int.Parse(query[1]);

    int highestLike = arr.Max();
    int highestLikeIndex = Array.IndexOf(arr, highestLike); // See notes below
    int postIndex = highestLikeIndex + 1;

    string str = $"{postIndex} {highestLike}";
    lists.Add(str);
}

Console.WriteLine();
foreach (var item in lists)
{
    Console.WriteLine(item);
}

// Notes: This is the index of the first occurrence of the highest like. So it'll return the smallest index if there are
// multiple highest likes. So no need to worry about extra sorting.