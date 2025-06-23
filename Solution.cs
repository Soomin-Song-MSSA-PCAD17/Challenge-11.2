namespace LeetCode1189
{
    public class Solution
    {
        public int MaxNumberOfBalloons(string text)
        {
            Dictionary<char, int> balloonChars = new();
            foreach (char c in "balloon")
            {
                balloonChars[c] = 0;
            }

            foreach (char c in text)
            {
                if (balloonChars.ContainsKey(c))
                {
                    balloonChars[c]++;
                }
            }

            int[] charCount = [balloonChars['b'], balloonChars['a'], balloonChars['l'] / 2, balloonChars['o'] / 2, balloonChars['n']];

            int balloons = balloonChars['b'];
            foreach (int count in charCount)
            {
                balloons = Math.Min(balloons, count);
            }

            return balloons;
        }
    }
}
