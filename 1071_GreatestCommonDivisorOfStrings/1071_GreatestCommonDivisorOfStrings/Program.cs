//1071.Greatest Common Divisor of Strings
//https://leetcode.com/problems/greatest-common-divisor-of-strings
//For two strings s and t, we say "t divides s" if and only if s = t + t + t + ... + t + t (i.e., t is concatenated with itself one or more times).

//Given two strings str1 and str2, return the largest string x such that x divides both str1 and str2.


//Example 1:
//Input: str1 = "ABCABC", str2 = "ABC"
//Output: "ABC"

//Example 2:
//Input: str1 = "ABABAB", str2 = "ABAB"
//Output: "AB"

//Example 3:
//Input: str1 = "LEET", str2 = "CODE"
//Output: ""

//Example 4:
//Input: str1 = "AAAAAB", str2 = "AAA"
//Output: ""​​​​​​​



//Constraints:
//1 <= str1.length, str2.length <= 1000
//str1 and str2 consist of English uppercase letters.

var str1 = "ABABAB";
var str2 = "ABAB";
var res = GcdOfStringsOpt(str1, str2);
Console.WriteLine(res);

string GcdOfStrings(string str1, string str2)
{
    var divisorLength = Gcd(str1.Length, str2.Length);
    var divisor = str1.Substring(0, divisorLength);

    for (int i = 0; i < str1.Length; i += divisorLength)
    {
        if (str1.Substring(i, divisorLength) != divisor)
        {
            return "";
        }
    }

    for (int i = 0; i < str2.Length; i += divisorLength)
    {
        if (str2.Substring(i, divisorLength) != divisor)
        {
            return "";
        }
    }

    return divisor;
}

string GcdOfStringsOpt(string str1, string str2)
{
    var divisorLength = Gcd(str1.Length, str2.Length);

    for (int i = 0; i < str1.Length; i++)
    {
        if (str1[i] != str1[i % divisorLength])
        {
            return "";
        }
    }

    for (int i = 0; i < str2.Length; i++)
    {
        if (str2[i] != str1[i % divisorLength])
        {
            return "";
        }
    }

    return str1.Substring(0, divisorLength);
}

int Gcd(int num1, int num2)
{
    while (num2 != 0)
    {
        var divisor = num1 % num2;

        num1 = num2;
        num2 = divisor;
    }

    return num1;
}