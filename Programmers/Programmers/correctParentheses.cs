namespace Programmers
{
    public class correctParentheses
    {
        public bool solution(string s)
        {
            bool answer = true;
            int cnt = 0;
            
            char leftPar = char.Parse("(");
            char rightPar = char.Parse(")");

            foreach (char word in s)
            {
                if (word.CompareTo(leftPar) == 0)
                    cnt++;
                else if (word.CompareTo(rightPar) == 0)
                    cnt++;

                if (cnt < 0)
                {
                    return false;
                }
            }


            return cnt == 0;
        }
    }
}