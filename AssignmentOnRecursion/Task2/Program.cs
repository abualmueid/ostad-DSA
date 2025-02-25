#region Without Recursion
/*
using System.Text;

int k = int.Parse(Console.ReadLine());

char FindKthCharacter(int k)
{
    StringBuilder word = new StringBuilder("a");

    while (word.Length < k) 
    {
        int length = word.Length;
        for (int i = 0; i < length; i++)
        {
            char nextChar = word[i] == 'z' ? 'a' : (char)(word[i] + 1);
            word.Append(nextChar);
        }
    }

    return word[k-1];
}

Console.WriteLine(FindKthCharacter(k));

// Time Complexity: O(klog2k) [Since every time word length is increasing almost twice times that's why log2k]
*/
#endregion

#region With Recursion

using System.Text;

char FindKthCharacter(int k, string s = "a")
{
    StringBuilder word = new StringBuilder(s);

    if (word.Length >= k) 
        return word[k - 1];

    while (word.Length < k)
    {
        int length = word.Length;
        for (int i = 0; i < length; i++)
        {
            char nextChar = word[i] == 'z' ? 'a' : (char)(word[i] + 1);
            word.Append(nextChar);
        }
    }

    return FindKthCharacter(k, word.ToString());
}

int k = int.Parse(Console.ReadLine());
Console.WriteLine(FindKthCharacter(k));

// Time Complexity: O(klog2k) [Since every time word length is increasing almost twice times that's why log2k]

#endregion