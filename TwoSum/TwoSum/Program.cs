//Two Sum
//You are given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
//You may assume that each input would have exactly one solution, and you may not use the same element twice.
//You can return the answer in any order.
 

//Example 1:
//Input: nums = [2,7,11,15], target = 9
//Output: [0,1]
//Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

//Example 2:
//Input: nums = [3,2,4], target = 6
//Output: [1,2]

//Example 3:
//Input: nums = [3,3], target = 6
//Output: [0,1]
 

//Constraints:
//2 <= nums.length <= 104
//-109 <= nums[i] <= 109
//-109 <= target <= 109
//Only one valid answer exists.
 

//Follow-up: Can you come up with an algorithm that is less than O(n2) time complexity?

Console.WriteLine("Hello, World!");


var res = TwoSumDict([2, 11, 7, 15], 9);
for (int i = 0; i < res.Length; i++)
{
    Console.Write(res[i]);
}

//Problem: https://leetcode.com/problems/two-sum/

//Time: O(n²)->O(n)
//Space: O(1)->O(n)

int[] TwoSum(int[] nums, int target)
{

    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = i + 1; j < nums.Length; j++)
        {
            if (nums[j] + nums[i] == target)
            {
                return new int[] { i, j };
            }
        }
    }


    return new int[] { 0, 0 };
}

// After using my brain
int[] TwoSumDict(int[] nums, int target)
{
    var dict = new Dictionary<int, int>();
    for (int i = 0; i < nums.Length; i++)
    {
        var need = target - nums[i];
        if (dict.TryGetValue(need, out int index))
        {
            return new int[] { index, i  };
        }
        else
        {
            dict[nums[i]] = i;
        }
    }

    throw new InvalidOperationException();
}