//1768.Merge Strings Alternately
//https://leetcode.com/problems/merge-strings-alternately
//You are given two strings word1 and word2. Merge the strings by adding letters in alternating order, starting with word1.
//If a string is longer than the other, append the additional letters onto the end of the merged string.

//Return the merged string.



//Example 1:
//Input: word1 = "abc", word2 = "pqr"
//Output: "apbqcr"
//Explanation: The merged string will be merged as so:
//word1: a    b   c
//word2:    p   q   r
//merged: a p b q c r

//Example 2:
//Input: word1 = "ab", word2 = "pqrs"
//Output: "apbqrs"
//Explanation: Notice that as word2 is longer, "rs" is appended to the end.
//word1:  a   b
//word2:    p   q   r   s
//merged: a p b q   r   s

//Example 3:
//Input: word1 = "abcd", word2 = "pq"
//Output: "apbqcd"
//Explanation: Notice that as word1 is longer, "cd" is appended to the end.
//word1: a    b   c   d
//word2:    p   q 
//merged: a p b q c   d 

//Constraints:
//1 <= word1.length, word2.length <= 100
//word1 and word2 consist of lowercase English letters.

using System.Text;

//merged: a p b q c r
var result = MergeAlternatelyOptimal("abcd", "pq");

Console.Write(result);

string MergeAlternately(string word1, string word2)
{
    var isFirstLongerOrEqual = word1.Length >= word2.Length;
    var sb = new StringBuilder();

    if (isFirstLongerOrEqual)
    {
        for (var i = 0; i < word1.Length; i++)
        {
            sb.Append(word1[i]);
            if (i < word2.Length)
            {
                sb.Append(word2[i]);
            }
        }
    }
    else
    {
        for (var i = 0; i < word2.Length; i++)
        {
            if (i < word1.Length)
            {
                sb.Append(word1[i]);
            }
            sb.Append(word2[i]);
        }
    }

    return sb.ToString();
}

string MergeAlternatelyOptimal(string word1, string word2)
{
    var resultLength = Math.Max(word1.Length, word2.Length);
    var sb = new StringBuilder();


    for (var i = 0; i < resultLength; i++)
    {
        if (i < word1.Length)
        {
            sb.Append(word1[i]);
        }

        if (i < word2.Length)
        {
            sb.Append(word2[i]);
        }
    }

    return sb.ToString();
}
