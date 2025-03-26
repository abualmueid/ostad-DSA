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
