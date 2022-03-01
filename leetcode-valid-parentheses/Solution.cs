public class Solution
{
    public bool IsValid(string str)
    {
        Stack<char> leftSymbols = new Stack<char>();

        foreach (char ch in str.ToCharArray())
        {
            // if left symbol is encountered
            if (ch == '(' || ch == '{' || ch == '[')
            {
                leftSymbols.Push(ch);
            }
            // if right symbol is encountered
            else if ((ch == ')') && !(leftSymbols.Count == 0) && (leftSymbols.Peek() == '('))
            {
                leftSymbols.Pop();
            }
            else if ((ch == '}') && !(leftSymbols.Count == 0) && (leftSymbols.Peek() == '{'))
            {
                leftSymbols.Pop();
            }
            else if ((ch == ']') && !(leftSymbols.Count == 0) && (leftSymbols.Peek() == '['))
            {
                leftSymbols.Pop();
            }
            // if none of the valid symbols is encountered
            else
            {
                return false;
            }
        }
        return leftSymbols.Count == 0;
    }
}