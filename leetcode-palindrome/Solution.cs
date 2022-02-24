public class Solution
{
    public bool IsPalindrome(int num)
    {
        int temp = num;
        int newNum = 0;

        while (num > 0)
        {
            int digit = num % 10;
            newNum = (newNum * 10) + digit;
            num = num / 10;
        }
        return temp == newNum;
    }
    public bool IsPalindrome2(int num)
    {
        string palindrome = "";
        string temp = num.ToString();
        for (int i = 0; i < temp.Length; i++)
        {
            int digit = num % 10;
            Console.WriteLine(digit);
            palindrome += digit.ToString();
            num = num / 10;
        }
        Console.WriteLine(palindrome);

        return palindrome == temp;
    }
}