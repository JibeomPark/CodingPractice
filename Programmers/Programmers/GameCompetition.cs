namespace Programmers
{
    public class GameCompetition
    {
        public int solution(int n, int a, int b)
        {
            int answer = 1;

            while (IsTheyMeet(a, b) == false)
            {
                a = NextRount(a);
                b = NextRount(b);
                answer++;
            }

            return answer;
        }

        public bool IsTheyMeet(int a, int b)
        {
            return (a % 2 == 0 && a - 1 == b ||
               b % 2 == 0 && b - 1 == a);
        }

        public int NextRount(int num)
        {
            if (num % 2 == 0)
                return num / 2;
            else
                return (num + 1) / 2;
        }
    }
}
