namespace Programmers
{
    public class SelfPlay
    {
        public int solution(int[] cards)
        {
            bool[] isCardOpened = new bool[cards.Length];
            List<int> m_boxGroupLengthList = new List<int>();
            List<int> group = new List<int>();
            int curser = 0;

            while (true)
            {

                if (curser >= cards.Length)
                    break;

                if (isCardOpened[curser] == true)
                {
                    curser++;
                }
                else
                {
                    group.Add(cards[curser]);
                    isCardOpened[curser] = true;

                    if (isCardOpened[cards[curser] - 1])
                    {
                        m_boxGroupLengthList.Add(group.Count);
                        group.Clear();
                        curser = 0;
                    }
                    else
                        curser = cards[curser] - 1;
                }
            }

            int largest = 0;
            int secondLargest = 0;

            foreach (var len in m_boxGroupLengthList)
            {
                if (len >= largest)
                {
                    secondLargest = largest;
                    largest = len;

                }

                else if (len >= secondLargest)
                    secondLargest = len;
            }

            return largest * secondLargest;
        }


    }
}
