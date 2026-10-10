//345.Reverse Vowels of a String
//https://leetcode.com/problems/reverse-vowels-of-a-string

//Given a string s, reverse only all the vowels in the string and return it.
//The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both lower and upper cases, more than once.

//Example 1:
//Input: s = "IceCreAm"
//Output: "AceCreIm"
//Explanation:
//The vowels in s are['I', 'e', 'e', 'A']. On reversing the vowels, s becomes "AceCreIm".

//Example 2:
//Input: s = "leetcode"
//Output: "leotcede"

//Constraints:

//1 <= s.length <= 3 * 105
//s consist of printable ASCII characters.

using System.Text;

var s = "IceCreAm";
var res = ReverseVowelsOptimal(s);
Console.WriteLine(res);

//Enterprise Edition
string ReverseVowelsOptimal(string s)
{
    var left = 0;
    var right = s.Length - 1;
    var allVowels = "AEOIUaeoiu";
    var result = new StringBuilder(s);

    while (left < right)
    {
        if (allVowels.Contains(s[left]) && allVowels.Contains(s[right]))
        {
            var temp = s[left];
            result[left] = s[right];
            result[right] = temp;

            left++;
            right--;
        }
        else
        {
            if (!allVowels.Contains(s[left]))
            {
                left++;
            }
            if (!allVowels.Contains(s[right]))
            {
                right--;
            }
        }
    }

    return result.ToString();
}

string ReverseVowels(string s)
{
    var vowels = new char[s.Length];
    var vowelsCount = 0;
    var allVowels = "AEOIUaeoiu";
    for (int i = 0; i < s.Length; i++)
    {
        if (allVowels.Contains(s[i]))
        {
            vowels[vowelsCount] = s[i];
            vowelsCount++;
        }
    }

    Console.WriteLine(s);
    Console.WriteLine(vowels);


    var sb = new StringBuilder(s);
    for (int i = 0; i < s.Length; i++)
    {
        if (allVowels.Contains(s[i]))
        {
            var temp1 = sb[i];
            var temp2 = vowels[vowelsCount - 1];
            var temp3 = vowelsCount;
            sb[i] = vowels[vowelsCount - 1];
            vowelsCount--;
        }

        Console.WriteLine(sb);
    }

    return sb.ToString();
}
