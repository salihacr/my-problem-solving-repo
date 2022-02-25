public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        StringBuilder longestCommonPrefix = new StringBuilder();
        if (strs == null || strs.Length == 0)
        {
            return "";
        }
        int minLength = strs[0].Length;
        for (int i = 1; i < Math.Min(minLength, strs[i].Length); i++)
        {
            minLength = Math.Min(minLength, strs[i].Length);
        }

        for (int i = 0; i < minLength; i++)
        {
            string currStr = strs[0];
            char current = currStr[i];

            foreach (var str in strs)
            {
                if (str[i] != current)
                {
                    return "";
                }
            }
            longestCommonPrefix.Append(current);
        }
        return longestCommonPrefix.ToString();
    }
}