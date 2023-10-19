namespace Programmers
{
    public class TagWords
    {
        public int[] solution(int n, string[] words)
        {
            int currentRound = 1;
            int currentPlayer = 1;
            char prevLastChar = words.First().First();
            Dictionary<char, List<string>> m_answerDic = new Dictionary<char, List<string>>();

            foreach (string word in words)
            {
                if (word.First() != prevLastChar)
                    return new int[] { currentPlayer, currentRound };

                prevLastChar = word[word.Length - 1];

                if (m_answerDic.TryGetValue(word.First(), out var list))
                {
                    if (list.Contains(word))
                    {
                        return new int[] { currentPlayer, currentRound };
                    }
                    else
                    {
                        list.Add(word);
                    }
                }
                else
                {
                    var newList = new List<string>() { word };
                    m_answerDic.Add(word.First(), newList);
                }
                
                currentPlayer++;

                if (currentPlayer > n)
                {
                    currentPlayer = 1;
                    currentRound++;
                }
            }

            return new int[] { 0, 0 };
        }
    }
}
