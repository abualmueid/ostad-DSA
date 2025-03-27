string[] input = Console.ReadLine().Split();
int n = int.Parse(input[0]);
int k = int.Parse(input[1]);
int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] query = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

for (int i = 0; i < k; i++)
{
    int index = FindMaxIndex(query[i]);
    Console.WriteLine(index == -1 ? 0 : index + 1);
}

int FindMaxIndex(int x) 
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

