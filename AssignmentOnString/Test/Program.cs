using System;

public class KOstad
{
    public static bool IsKOstad(string str1, string str2, int k)
    {
        int n1 = str1.Length;
        int n2 = str2.Length;

        int[,] dp = new int[n1 + 1, n2 + 1];

        for (int i = 0; i <= n1; i++)
        {
            dp[i, 0] = i;
        }
        for (int j = 0; j <= n2; j++)
        {
            dp[0, j] = j;
        }

        for (int i = 1; i <= n1; i++)
        {
            for (int j = 1; j <= n2; j++)
            {
                if (str1[i - 1] == str2[j - 1])
                {
                    dp[i, j] = dp[i - 1, j - 1];
                }
                else
                {
                    dp[i, j] = 1 + Math.Min(Math.Min(dp[i - 1, j], dp[i, j - 1]), dp[i - 1, j - 1]); // Corrected min calculation
                }
            }
        }

        int editDistance = dp[n1, n2];

        return editDistance <= k;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(IsKOstad("anagram", "grammar", 3)); // Output: True
        Console.WriteLine(IsKOstad("ostad", "boss", 1)); // Output: False
        Console.WriteLine(IsKOstad("kitten", "sitting", 3)); // Output: True
        Console.WriteLine(IsKOstad("dcat", "cat", 1)); // Output: True
        Console.WriteLine(IsKOstad("abc", "bca", 1)); // Output: False
        Console.WriteLine(IsKOstad("intention", "execution", 5)); // Output: True
    }
}