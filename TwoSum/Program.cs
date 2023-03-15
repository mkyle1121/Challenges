

var solution = new Solution();
var result = solution.TwoSum(new[] { 2, 7, 11, 15 }, 9);
foreach (var item in result)
{
    Console.WriteLine(item);
}


public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            var nextNum = i + 1;

            while (nextNum < nums.Length)
            {              
                if (nums[i] + nums[nextNum] == target)
                {
                    return new[] { i, nextNum };
                }
                else
                {
                    nextNum++;
                }
            }
        }
        return new[] { 0, 0 };
    }
}