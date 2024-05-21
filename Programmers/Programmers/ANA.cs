namespace Programmers
{
    public class ANA
    {
        public static void Main()
        {
            var info = Console.ReadLine().Split();
            var size = int.Parse(info[0]);
            var start = int.Parse(info[1]);

            var input = new int[size, size];

            for(int i = 0; i < size; i++)
            {
                var line = Console.ReadLine().Split();
                for(int j = 0; j < size; j++)
                {
                    input[i, j] = int.Parse(line[j]);
                }
            }

            Console.WriteLine(GetShortestDistance(ref input, start));

        }

        private static int GetShortestDistance(ref int[,] path, int s)
        {
            UpdatePath(ref path);
            return CalcDistance(ref path, s);
        }

        private static void UpdatePath(ref int[,] path)
        {
            int size = path.GetLength(0);

            for (int m = 0; m < size; m++)
            {
                for (int start = 0; start < size; start++)
                {
                    for (int end = 0; end < size; end++)
                    {
                        if (path[start, end] > path[start, m] + path[m, end])
                            path[start, end] = path[start, m] + path[m, end];
                    }
                }
            }
        }

        private static int CalcDistance(ref int[,] path, int s)
        {
            int size = path.GetLength(0);
            var visited = new bool[size];
            visited[s] = true;
            int cost = int.MaxValue;

            VisitNext(visited, ref path, ref cost, s, 0);
            return cost;
        }

        private static void VisitNext(bool[] visited, ref int[,] path, ref int cost, int curNode, int curCost)
        {
            bool isVisitAll = true;

            for (int i = 0; i < visited.Length; i++)
            {
                if (visited[i] == false)
                {
                    isVisitAll = false;
                    visited[i] = true;
                    VisitNext(visited, ref path, ref cost, i, curCost + path[curNode, i]);
                    visited[i] = false;
                }
            }

            if(isVisitAll)
                cost = Math.Min(cost, curCost); 
        }
    }
}
