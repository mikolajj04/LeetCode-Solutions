
//Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
//Input: nums = [2,7,11,15], target = 9
//Output: [0,1]
//Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    int[] answ = new int[] { i, j };
                    return answ;
                }

            }

        }
        return Array.Empty<int>();
    }

}
