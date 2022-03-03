public class Solution {
    public int LengthOfLastWord(string str)
    {
        str = str.TrimStart().TrimEnd();
        string lastWord = str.Split(" ").Last();
        return lastWord.Length;
    }
}