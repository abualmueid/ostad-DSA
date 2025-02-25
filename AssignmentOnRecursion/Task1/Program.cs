#region Using Loop
/*
int n = int.Parse(Console.ReadLine());

bool IsPowerOfFive(int n) 
{
    if (n < 1) return false;

    for (int x = 0; Math.Pow(5, x) <= n; x++)
    {
        if (Math.Pow(5, x) == n)
        {
            return true;
        }
    }

    return false;
}

Console.WriteLine(IsPowerOfFive(n));

// Time Complexity: O(log5(n))
*/
#endregion

#region Using Recursion

int n = int.Parse(Console.ReadLine());

bool IsPowerOfFive(int n, int x = 0) 
{
    if (n < 1) return false;

    int power = (int)Math.Pow(5, x);
    if (power == n) return true;
    if (power > n) return false;

    return IsPowerOfFive(n, ++x);
}

Console.WriteLine(IsPowerOfFive(n));

// Time Complexity: O(log5(n))

#endregion