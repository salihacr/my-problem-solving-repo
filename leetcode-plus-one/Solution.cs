public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        int carry = 1;
        int n = digits.Length;

        for (int i = n - 1; i >= 0; i--)
        {
            int sum = digits[i] + carry;
            carry = sum / 10;
            digits[i] = sum % 10;
        }
        if (carry > 0)
        {
            int[] sum = new int[n + 1];
            sum[0] = carry;
            for (int i = 1; i < sum.Length; i++)
            {
                sum[i] = digits[i - 1];
            }
            return sum;
        }
        else
            return digits;
    }
}