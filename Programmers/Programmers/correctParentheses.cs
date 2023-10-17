namespace Programmers
{
    public class correctParentheses
    {
        public bool solution(string s)
        {
            bool answer = true;
            int a = 0;
            int b = 0;
            char leftPar = char.Parse("(");
            char rightPar = char.Parse(")");

            foreach (char word in s)
            {
                
                if (word.CompareTo(leftPar) == 0)
                    a++;
                else if (word.CompareTo(rightPar) == 0)
                    b++;

                if (a - b < 0)
                {
                    return false;
                }
            }


            return a == b;
        }
    }
}