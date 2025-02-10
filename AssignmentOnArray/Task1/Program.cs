int numRows = 5;
var triangle = GenerateTriangle(numRows);

foreach (var row in triangle)
{
    Console.WriteLine(string.Join(" ", row));
}

List<List<int>> GenerateTriangle(int numRows)
{
    List<List<int>> triangle = new List<List<int>>();

    for (int i = 0; i < numRows; i++)
    {
        var row = new List<int>();

        for (int j = 0; j <= i; j++)
        {
            if (j == 0 || j == i)
            {
                row.Add(1);
            }
            else
            {
                row.Add(triangle[i - 1][j - 1] + triangle[i - 1][j]);
            }
        }

        triangle.Add(row);
    }

    return triangle;
}
