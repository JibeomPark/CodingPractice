using System;
using System.Text;

public class NumberPartners
{
    public static void Main(string[] args)
    {
        Solution m1 = new Solution();
        Console.WriteLine(m1.solution("5525", "1255"));
    }
}
public class Solution
{
    public string solution(string X, string Y)
    {
        string answer = "";

        List<Char> wordListX = X.ToList();
        List<Char> wordListY = Y.ToList();

        int currentNumber = 9;
        StringBuilder builder = new StringBuilder(answer);

        while (true)
        {
            char curser = char.Parse(currentNumber.ToString());

            int leng = 0;
            int lengX = wordListX.Where(x => x == curser).Count();
            int lengY = wordListY.Where(x => x == curser).Count();

            if (lengX <= lengY)
                leng = lengX;
            else
                leng = lengY;

            for (int i = 0; i < leng; i++)
                builder.Append(curser);

            currentNumber--;
            if (currentNumber < 0)
                break;
        }

        if (builder.Length == 0)
            return "-1";

        if (builder[0] == char.Parse("0"))
            return "0";

        return builder.ToString();

        
    }
}