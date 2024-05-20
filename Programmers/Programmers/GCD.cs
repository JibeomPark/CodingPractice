namespace Programmers
{
    public class GCD
    {
        public static void Main()
        {
            int.TryParse(Console.ReadLine(), out int number);
            int a, b;
            var ans = new List<int>();

            for (int i = 0; i < number; i++)
            {
                var pair = Console.ReadLine().Split();

                int.TryParse(pair[0], out a);
                int.TryParse(pair[1], out b);

                ans.Add(GetGCD(a, b));
            }

            for (int i = 0; i < number; i++)
                Console.WriteLine(ans[i]);
        }

        private static int GetGCD(int a, int b)
        {
            if (a == 1 || b == 1)
                return a > b ? a : b;

            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }

            int mod = 1;

            for (int j = 2; j <= a;)
            {
                if (a % j == 0 && b % j == 0)
                {
                    mod *= j;
                    a /= j;
                    b /= j;
                    j = 2;
                }
                else
                    j++;
            }

            return a * b * mod;
        }
    }
}
