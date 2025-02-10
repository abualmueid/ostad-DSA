//int[] nums = { 3, 6, 9, 1 };
int[] nums = { 10 };

Console.WriteLine(MaxGap(nums));

int MaxGap(int[] nums)
{
    if (nums.Length < 2)
    {
        return 0;
    }

    Array.Sort(nums);

    int maxGap = 0;
    for (int i = 1; i < nums.Length; i++)
    {
        maxGap = Math.Max(maxGap, nums[i] - nums[i - 1]);
    }

    return maxGap;
}