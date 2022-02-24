public class Solution
{
    public int RomanToInt(string str)
    {
        Dictionary<char, int> romanDict = new Dictionary<char, int>();

        romanDict.Add('I', 1);
        romanDict.Add('V', 5);
        romanDict.Add('X', 10);
        romanDict.Add('L', 50);
        romanDict.Add('C', 100);
        romanDict.Add('D', 500);
        romanDict.Add('M', 1000);
	
        int len = str.Length;
        int result = 0;

        for (int i = 0; i < str.Length; i++)
        {
            int current = romanDict[str[i]];
            if (i == str.Length - 1 || romanDict[str[i + 1]] <= current)
            {
                result += current;
            }
            else
            {
                result -= current;
            }
        }
        return result;
    }
}