#region Linear Search

/*
int n = int.Parse(Console.ReadLine());
int[] a = new int[n];

string[] s = Console.ReadLine().Split();
for (int i = 0; i < n; i++)
{
    a[i] = int.Parse(s[i]);
}

int k = int.Parse(Console.ReadLine());
int[] output = new int[k];
for (int i = 0; i < k; i++) 
{
    string[] input = Console.ReadLine().Split();
    int l = int.Parse(input[0]);
    int r = int.Parse(input[1]);

    int counter = 0;
    for (int j = l; j <= r; j++)
    {
        for (int p = 0; p < n; p++)
        {
            if (a[p] == j)
            {
                counter++;
            }
        }
    }
    output[i] = counter;
}

Console.WriteLine();
foreach (int i in output)
{
    Console.WriteLine(i);
}
*/
#endregion Linear Search

#region Binary Search

int n = int.Parse(Console.ReadLine());
int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int k = int.Parse(Console.ReadLine());
int[] output = new int[k];

Array.Sort(a);

for (int i = 0; i < k; i++)
{
    string[] input = Console.ReadLine().Split();
    int l = int.Parse(input[0]);
    int r = int.Parse(input[1]);

    int leftIndex = FindLeftIndex(l);
    int rightIndex = FindRightIndex(r);

    if (leftIndex == -1 || rightIndex == -1)
    {
        output[i] = 0;
    }
    else
    {
        output[i] = (rightIndex - leftIndex) + 1;
    }
}

Console.WriteLine();
foreach (int i in output)
{
    Console.WriteLine(i);
}

int FindLeftIndex(int x)
{
    int l = 0;
    int r = n - 1;
    int result = -1;

    while (l <= r)
    {
        int mid = (l + r) / 2;

        if (x <= a[mid])
        {
            result = mid;
            r = mid - 1;
        }
        else
        {
            l = mid + 1;
        }
    }

    return result;
}

int FindRightIndex(int x)
{
    int l = 0;
    int r = n - 1;
    int result = -1;

    while (l <= r)
    {
        int mid = (l + r) / 2;

        if (x >= a[mid])
        {
            result = mid;
            l = mid + 1;
        }
        else
        {
            r = mid - 1;
        }
    }

    return result;
}

#endregion Binary Search
