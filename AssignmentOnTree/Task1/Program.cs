using Task1;

var nodes = new List<TreeNode>();
var InOrderOutput = new List<int>();
var PreOrderOutput = new List<int>();
var PostOrderOutput = new List<int>();

int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split();
    int val = int.Parse(input[0]);
    int left = int.Parse(input[1]);
    int right = int.Parse(input[2]);

    nodes.Add(new TreeNode(val, left, right));
}

InOrder(0);
PreOrder(0);
PostOrder(0);

Console.WriteLine();
Console.WriteLine(string.Join(" ", InOrderOutput));
Console.WriteLine(string.Join(" ", PreOrderOutput));
Console.WriteLine(string.Join(" ", PostOrderOutput));

void InOrder(int index)
{
    if (index == -1) return;

    InOrder(nodes[index].left);
    InOrderOutput.Add(nodes[index].val);
    InOrder(nodes[index].right);
}

void PreOrder(int index)
{
    if (index == -1) return;

    PreOrderOutput.Add(nodes[index].val);
    PreOrder(nodes[index].left);
    PreOrder(nodes[index].right);
}

void PostOrder(int index)
{
    if (index == -1) return;

    PostOrder(nodes[index].left);
    PostOrder(nodes[index].right);
    PostOrderOutput.Add(nodes[index].val);
}