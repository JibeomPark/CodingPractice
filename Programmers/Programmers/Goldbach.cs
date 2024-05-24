namespace Programmers
{
    public class Goldbach
    {
        public static void Main()
        {
            var sr = new StreamReader(Console.OpenStandardInput());
            var sw = new StreamWriter(Console.OpenStandardOutput());

            var caseAmount = int.Parse(sr.ReadLine());
            var input = new List<int>();

            for (int i = 0; i < caseAmount; i++)
            {
                input.Add(int.Parse(sr.ReadLine()));
            }

            var result = FindGoldBachPartion(input);

            for (int i = 0; i < caseAmount; i++)
            {
                sw.WriteLine($"{result[i].Item1} {result[i].Item2}");
            }

            sr.Close();
            sw.Flush();
            sw.Close();
        }

        private static List<Tuple<int, int>> FindGoldBachPartion(List<int> n)
        {
            var ans = new List<Tuple<int, int>>();

            for (int i = 0; i < n.Count; i++)
            {
                var isNotPrime = new bool[n[i]];

                var primeNumArr = GetAllPrimeNumberArray(n[i], ref isNotPrime);
                int a = 0, b = int.MaxValue;

                foreach (int p1 in primeNumArr)
                {
                    if (p1 > n[i] / 2)
                        break;

                    var p2 = n[i] - p1;

                    if (isNotPrime[p2 - 1])
                        continue;

                    if (p2 - p1 < b - a)
                    {
                        a = p1;
                        b = p2;
                    }
                }

                ans.Add(new Tuple<int, int>(a, b));
            }

            return ans;
        }

        private static List<int> GetAllPrimeNumberArray(int n, ref bool[] isNotPrime)
        {
            int dest = (int)Math.Truncate(Math.Sqrt(n));
            var result = new List<int>();

            for (int i = 2; i <= dest; i++)
            {
                if (isNotPrime[i - 1])
                    continue;

                for (int j = 2; i * j <= n; j++)
                {
                    if (isNotPrime[i - 1])
                        continue;

                    if (i * j % i == 0)
                        isNotPrime[i * j - 1] = true;
                }

            }

            for (int i = 1; i < n; i++)
            {
                if (isNotPrime[i] == false)
                    result.Add(i + 1);
            }

            return result;
        }


    }
}
