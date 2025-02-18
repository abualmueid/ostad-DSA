using System.Text;

string s = Console.ReadLine();
StringBuilder sb = new StringBuilder();

int count = 1;
char currentChar = s[0];

for (int i = 1; i < s.Length; i++)
{
    if (s[i] == currentChar)
    {
        count++;
    }
    else
    {
        sb.Append(currentChar).Append(count);
        count = 1;
        currentChar = s[i];
    }
}

sb.Append(currentChar).Append(count);

string s2 = sb.ToString();
char[] charArray = s2.ToCharArray();
Array.Reverse(charArray);
string reversedStr = new string(charArray);

Console.WriteLine(reversedStr);