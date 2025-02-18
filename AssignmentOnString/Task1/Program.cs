using System;

string str1 = Console.ReadLine();
string str2 = Console.ReadLine();
int k = int.Parse(Console.ReadLine());

Console.WriteLine(AreKOstad(str1, str2, k));

string AreKOstad(string str1, string str2, int k)
{
    int editDistance = EditDistance(str1, str2);

    return (editDistance <= k) ? "Yes" : "No";
}

int EditDistance(string str1, string str2)
{
    int m = str1.Length;
    int n = str2.Length;

    int[,] distanceTable = new int[m + 1, n + 1];

    for (int i = 0; i <= m; i++)
    {
        for (int j = 0; j <= n; j++)
        {
            if (i == 0)
            {
                distanceTable[i, j] = j;
            }
            else if (j == 0)
            {
                distanceTable[i, j] = i;
            }
            else if (str1[i - 1] == str2[j - 1])
            {
                distanceTable[i, j] = distanceTable[i - 1, j - 1];
            }
            else
            {
                distanceTable[i, j] = 1 + Math.Min(distanceTable[i - 1, j - 1], Math.Min(distanceTable[i - 1, j], distanceTable[i, j - 1]));
            }
        }
    }

    return distanceTable[m, n];
}
