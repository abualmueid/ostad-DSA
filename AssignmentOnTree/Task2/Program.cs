int n = int.Parse(Console.ReadLine());
int[] parent = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

// Initialize the tree
var tree = new List<int>[n];
for (int i = 0; i < n; i++)
{
    tree[i] = new List<int>();
}

// Build the tree
int root = -1;
for (int i = 0; i < n; i++)
{
    if (parent[i] == -1)
    {
        root = i;
    } 
    else
    {
        tree[parent[i]].Add(i);
    }
}

// Calculate height
int height = GetHeight(root);
Console.WriteLine(height);

int GetHeight(int node)
{
    if (tree[node].Count == 0) return 1;

    int maxChildHeight = 0;
    foreach (int child in tree[node])
    {
        int childHeight = GetHeight(child);
        if (childHeight > maxChildHeight)
        {
            maxChildHeight = childHeight;
        }
    }

    return 1 + maxChildHeight;
}