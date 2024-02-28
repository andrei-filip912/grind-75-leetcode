int[] nums = new int[]{ 2, 7, 11, 15 };
int target = 9;
// https://leetcode.com/problems/two-sum/description/

int[] TwoSumSolution1(int[] nums, int target)
{
    var map = new Dictionary<int, int>();
    for (int i = 0; i < nums.Length; i++)
    {
        map.TryAdd(nums[i], i);
    }

    for (int i = 0; i < nums.Length; i++)
    {
        var complement = target - nums[i];
        if(map.ContainsKey(complement))
            return new int[] { i, map[complement] };
    }
    return new int[] { -1, 1 };
}

var result = TwoSumSolution1(nums, target);
Console.WriteLine(result[0] + " " + result[1]);

int[] TwoSumSolution2(int[] nums, int target)
{
    var pairs = new Dictionary<int, int>();

    for (int i = 0; i < nums.Length; i++)
    {
        var complement = target - nums[i];
        if (pairs.ContainsKey(complement))
        {
            return new int[] { pairs[complement], i };
        }
        else
        {
            pairs.TryAdd(nums[i], i);
        }
    }
    return new int[] { -1, 1 };
}
var result2 = TwoSumSolution2(nums, target);
Console.WriteLine(result[0] + " " + result[1]);