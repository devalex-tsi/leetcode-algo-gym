//605.Can Place Flowers
//https://leetcode.com/problems/can-place-flowers
//Easy
//Topics
//premium lock icon
//Companies
//You have a long flowerbed in which some of the plots are planted, and some are not. However, flowers cannot be planted in adjacent plots.

//Given an integer array flowerbed containing 0's and 1's, where 0 means empty and 1 means not empty, and an integer n,
//return true if n new flowers can be planted in the flowerbed without violating the no-adjacent-flowers rule and false otherwise.

//Example 1:
//Input: flowerbed = [1, 0, 0, 0, 1], n = 1
//Output: true

//Example 2:
//Input: flowerbed = [1, 0, 0, 0, 1], n = 2
//Output: false

//Constraints:
//1 <= flowerbed.length <= 2 * 104
//flowerbed[i] is 0 or 1.
//There are no two adjacent flowers in flowerbed.
//0 <= n <= flowerbed.length


int[] flowerbed = new[] { 0, 0 };
int flowerCount = 2;

bool res = CanPlace(flowerbed, flowerCount);
Console.WriteLine(res);

bool CanPlace(int[] flowerbed, int flowerCount)
{
    if (flowerCount == 0)
    {
        return true;
    }

    for (int i = 0; i < flowerbed.Length; i++)
    {
        if (flowerbed.Length == 1 && flowerCount == 1 && flowerbed[i] == 0)
        {
            return true;
        }
        else
        {
            if (flowerCount == 1 && flowerbed[i] == 1 && flowerbed.Length == 1)
            {
                return false;
            }
        }


        if (i == 0 && flowerbed[i + 1] == 0 && flowerbed[i] == 0)
        {
            flowerbed[i] = 1;
            flowerCount--;
        } else
        if (i != 0 && i != flowerbed.Length - 1 && flowerbed[i + 1] == 0 && flowerbed[i - 1] == 0 && flowerbed[i] == 0)
        {
            flowerbed[i] = 1;
            flowerCount--;
        } else
        if (i == flowerbed.Length - 1 && flowerbed[i - 1] == 0 && flowerbed[i] == 0)
        {
            flowerbed[i] = 1;
            flowerCount--;
        }

        if (flowerCount == 0)
        {
            return true;
        }
    }

    return false;
}