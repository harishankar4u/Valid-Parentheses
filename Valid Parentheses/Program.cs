class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(IsValidParentheses("()")); // output true
        Console.WriteLine(IsValidParentheses("()[]{}")); //output true
        Console.WriteLine(IsValidParentheses("(]")); //output false
        Console.WriteLine(IsValidParentheses("([])"));  //output true
    }
    public static bool IsValidParentheses(string p)
    {
        string s = p;
        while (s.Contains("()") || s.Contains("{}")|| s.Contains("[]"))
        {
            s=s.Replace("()", "")
                 .Replace("{}", "")
                 .Replace("[]", "");

        }
        return s.Length==0;
    }
}