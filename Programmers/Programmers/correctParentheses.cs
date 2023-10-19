namespace Programmers
{
    public class correctParentheses
    {
        public bool solution(string s)
        {
            int cnt = 0;
            foreach (char word in s)
            {
                if (word == '(')
                    cnt++;
                else if (word == ')')
                    cnt--;

                if (cnt < 0)
                    return false;
            }

            return cnt == 0;
        }
    }
}