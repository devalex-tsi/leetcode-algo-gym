// Merge Sorted Array
// You are given two integer arrays nums1 and nums2, sorted in non-decreasing order,
// and two integers m and n, representing the number of elements in nums1 and nums2 respectively.
// Merge nums1 and nums2 into a single array sorted in non-decreasing order.
// The final sorted array should be stored inside nums1.
// nums1 has a length of m + n, where the last n elements are set to 0 and should be ignored.
//
// Example 1:
// Input: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
// Output: [1,2,2,3,5,6]
//
// Example 2:
// Input: nums1 = [1], m = 1, nums2 = [], n = 0
// Output: [1]
//
// Problem: https://leetcode.com/problems/merge-sorted-array/

Console.WriteLine("Hello, World!");

var nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
var m = 3;
var nums2 = new int[] { 2, 5, 6 };
var n = 3;

var res = Merge(nums1, m, nums2, n);
for (int i = 0; i < res.Length; i++)
{
    Console.Write(res[i] + " ");
}

int[] Merge(int[] nums1, int m, int[] nums2, int n)
{
    var k = m + n - 1;
    for (int i = n - 1, j = m - 1; i >= 0 ; k--)
    {
        if (j<0)
        {
            nums1[k] = nums2[i];
            i--;
            continue;
        }
        var temp = nums2[i];
        var temp2 = nums1[j];
        if (nums2[i] > nums1[j])
        {
            nums1[k] = nums2[i];
            i--;
        }
        else
        {
            nums1[k] = nums1[j];
            j--;
        }
    }

    return nums1;
}
